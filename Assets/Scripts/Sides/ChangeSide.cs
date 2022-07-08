using Player;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Sides
{
    public class ChangeSide : MonoBehaviour
    {
        [SerializeField] private BoxCollider2D left;
        [SerializeField] private BoxCollider2D right;
        [SerializeField] private float offsetPlayer;
        [SerializeField] private float offsetCollider;

        private Vector3 _min;
        private Vector3 _max;
        
        private void Awake()
        {
            _min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
            _max = Camera.main.ViewportToWorldPoint(new Vector3(1f, 1f, Camera.main.nearClipPlane));
            left.transform.position = new Vector2(_min.x - offsetCollider, transform.position.y);
            right.transform.position = new Vector2(_max.x + offsetCollider, transform.position.y);
        }
        
        private void Start()
        {
            left.OnTriggerEnter2DAsObservable()
                .Subscribe(col =>
                {
                    PlayerController player = col.GetComponent<PlayerController>();

                    if (player && player.transform.position.x < _min.x)
                    {
                        player.transform.position = new Vector2(_max.x - offsetPlayer, player.transform.position.y);
                    }
                }).AddTo(this);
            
            right.OnTriggerEnter2DAsObservable()
                .Subscribe(col =>
                {
                    PlayerController player = col.GetComponent<PlayerController>();

                    if (player && player.transform.position.x > _max.x)
                    {
                        player.transform.position = new Vector2(_min.x + offsetPlayer, player.transform.position.y);
                    }
                }).AddTo(this);
        }
    }
}