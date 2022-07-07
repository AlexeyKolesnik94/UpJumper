using System;
using Platforms;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float jumpForce;
        [SerializeField] private float speed;

        private Rigidbody2D _rb;
        private Animator _animator;

        private Vector3 _acceleration;

        private readonly CompositeDisposable _disposable = new CompositeDisposable();

        private static readonly int Jump = Animator.StringToHash("Jump");
       

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
        }

        private void Start()
        {
            this.OnCollisionEnter2DAsObservable()
                .Subscribe(col =>
                {
                    if (!(col.relativeVelocity.y > 0)) return;
                    if (col.collider.GetComponent<FallingPlatform>())
                    {
                        Destroy(col.gameObject);
                        Jumping(jumpForce / 2);
                    } else
                    {
                        Jumping(jumpForce);
                    }
                }).AddTo(_disposable);
        }

        private void FixedUpdate()
        {
            Moving();
            BtnMoving();
        }

        private void OnDisable()
        {
            _disposable.Dispose();
        }

        private void Jumping(float force)
        {
            _rb.velocity = Vector2.up * force;
            _animator.SetBool(Jump, true);
        }

        private void Moving()
        {
            _acceleration = Input.acceleration;
            _rb.velocity = new Vector3(_acceleration.x * speed, _rb.velocity.y, 0f);
        }

        private void BtnMoving()
        {
            if (Input.GetKey(KeyCode.A))
            {
                _rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, _rb.velocity.y, 0f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                _rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, _rb.velocity.y, 0f);
            }
        }
    }
}
