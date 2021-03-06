using Platforms;
using UnityEngine;

namespace UI.UIHandlers
{
    public class FinishUIHandler : MonoBehaviour
    {
        [SerializeField] private Canvas finishCanvas;

        private void Start()
        {
            FinishEvent.OnFinishing.AddListener(FinishHandler);
        }

        private void FinishHandler()
        {
            finishCanvas.gameObject.SetActive(true);
        }
        
        private void OnDisable()
        {
            FinishEvent.OnFinishing.RemoveListener(FinishHandler);
        }
    }
}