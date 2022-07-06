using Player;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Platforms
{
    public class Finish : MonoBehaviour
    {
        private void Start()
        {
            this.OnTriggerEnter2DAsObservable()
                .Subscribe(col =>
                {
                    if (col.GetComponent<PlayerController>())
                    {
                        SceneManager.LoadScene("SampleScene");
                    }
                }).AddTo(this);
        }
    }
}
