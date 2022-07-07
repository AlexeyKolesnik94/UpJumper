using Player;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Platforms
{
    public class Finish : MonoBehaviour
    {
        private void Start()
        {
            this.OnTriggerEnter2DAsObservable()
                .Subscribe(col =>
                {
                    if (!col.GetComponent<PlayerController>()) return;
                    col.gameObject.SetActive(false);
                    FinishEvent.SendFinishing();
                }).AddTo(this);
        }
    }
}
