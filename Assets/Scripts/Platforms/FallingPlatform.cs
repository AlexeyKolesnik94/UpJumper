using Player;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Platforms
{
    public class FallingPlatform : MonoBehaviour
    {
        private Rigidbody2D _rb;

        private readonly CompositeDisposable _disposable = new CompositeDisposable();
        
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            
            this.OnCollisionEnter2DAsObservable()
                .Subscribe(col =>
                {
                    if (col.collider.GetComponent<PlayerController>())
                    {
                        _rb.bodyType = RigidbodyType2D.Dynamic;
                    }
                }).AddTo(_disposable);
        }

        private void OnDisable()
        {
            _disposable.Dispose();
        }
    }
}
