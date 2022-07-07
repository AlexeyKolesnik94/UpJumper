using Player;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace SupportScripts
{
    public class DeadLine : MonoBehaviour
    {
        private void Start()
        {
            this.OnTriggerEnter2DAsObservable()
                .Subscribe(col =>
                {
                    col.gameObject.SetActive(false);

                    if (col.GetComponent<PlayerController>())
                    {
                        LoseEvent.SendLoseGame();
                    }
                }).AddTo(this);
        }
    }
}
