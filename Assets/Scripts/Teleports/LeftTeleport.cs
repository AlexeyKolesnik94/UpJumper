using Player;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Teleports
{
    public class LeftTeleport : MonoBehaviour
    {
        private CompositeDisposable _disposable = new CompositeDisposable();
        
        private Vector3 _min;
        private Vector3 _max;
        private void Awake()
        {
            _min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
            _max = Camera.main.ViewportToWorldPoint(new Vector3(1f, 1f, Camera.main.nearClipPlane));
            transform.position = new Vector2(_min.x - 0.2f, transform.position.y);
        }
        
        private void Start()
        {
            this.OnTriggerEnter2DAsObservable()
                .Subscribe(col =>
                {
                    PlayerController player = col.GetComponent<PlayerController>();
                    
                    if (player)
                    {
                        player.transform.position = new Vector2(_max.x - 0.05f, player.transform.position.y);
                    }
                    
                }).AddTo(_disposable);
        }
        
        private void OnDisable()
        {
            _disposable.Dispose();
        }
    }
}
