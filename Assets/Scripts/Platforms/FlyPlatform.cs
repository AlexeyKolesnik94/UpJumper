using UnityEngine;

namespace Platforms
{
    public class FlyPlatform : MonoBehaviour
    {
        [SerializeField] private float speed;

        private Vector3 _min;
        private Vector3 _max;

        private bool _isMovingRight;
        
        private void Update()
        {
            if (transform.position.x > _max.x) _isMovingRight = false;

            if (transform.position.x < _min.x) _isMovingRight = true;
            
            MovingPlatform();
        }

        private void Start()
        {
            _min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));   
            _max = Camera.main.ViewportToWorldPoint(new Vector3(1f, 1f, Camera.main.nearClipPlane));

            _isMovingRight = true;
        }
        
        
        private void MovingPlatform()
        {
            if (_isMovingRight)
            {
                transform.position = new Vector2(transform.position.x + speed * Time.deltaTime,
                    transform.position.y);
            } 
            
            if (!_isMovingRight)
            {
                transform.position = new Vector2(transform.position.x - speed * Time.deltaTime,
                    transform.position.y);
            }
        }
    }
}
