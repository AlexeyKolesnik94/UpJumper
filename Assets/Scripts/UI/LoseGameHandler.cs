using SupportScripts;
using UnityEngine;

namespace UI
{
    public class LoseGameHandler : MonoBehaviour
    {
        [SerializeField] private Canvas loseGameCanvas;

        private void Start()
        {
            LoseEvent.OnLoseGame.AddListener(LoseHandler);
        }

        private void LoseHandler()
        {
            loseGameCanvas.gameObject.SetActive(true);
        }
    }
}