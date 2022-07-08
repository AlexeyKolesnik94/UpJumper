using SupportScripts;
using UnityEngine;

namespace UI.UIHandlers
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
        
        private void OnDisable()
        {
            LoseEvent.OnLoseGame.RemoveListener(LoseHandler);
        }
    }
}