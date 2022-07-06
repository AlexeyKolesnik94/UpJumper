using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace SupportScripts
{
    public class DeadLine : MonoBehaviour
    {
        private void Start()
        {
            this.OnCollisionEnter2DAsObservable()
                .Subscribe(col =>
                {
                    col.collider.gameObject.SetActive(false);
                }).AddTo(this);
        }
    }
}
