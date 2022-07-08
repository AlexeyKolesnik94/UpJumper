using Player;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Teleports
{
    public class LeftTeleport : MonoBehaviour
    {
        private Vector3 _min;
        private Vector3 _max;

        private readonly Camera _camera = Camera.main;
        
        private void Awake()
        {
            _min = _camera.ViewportToWorldPoint(new Vector3(0, 0, _camera.nearClipPlane));
            _max = _camera.ViewportToWorldPoint(new Vector3(1f, 1f, _camera.nearClipPlane));
            transform.position = new Vector2(_min.x - 0.2f, transform.position.y);
        }
        
        private void Start()
        {
            this.OnTriggerEnter2DAsObservable()
                .Subscribe(col =>
                {
                    PlayerController player = col.GetComponent<PlayerController>();
                    
                    if (player)
                        player.transform.position = new Vector2(_max.x - 0.05f, player.transform.position.y);
                }).AddTo(this);
        }
    }
}
