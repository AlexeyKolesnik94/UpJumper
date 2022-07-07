using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Player
{
    public class TeleportPlayer : MonoBehaviour
    {
        [SerializeField] private BoxCollider2D leftTeleport;
        [SerializeField] private BoxCollider2D rightTeleport;

       
       

        private CompositeDisposable _disposable = new CompositeDisposable();
        
        private void Awake()
        {
            
            
        }

        private void Start()
        {
            
            
            
        }

        private void OnDisable()
        {
            _disposable.Dispose();
        }
    }
}