using UI.Events;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.UIHandlers
{
    public class UIMenuHandler : MonoBehaviour
    {
        private void Start()
        {
            UIEvents.OnStartBtnClick.AddListener(StartBtnHandler);
        }

        private void StartBtnHandler()
        {
            SceneManager.LoadSceneAsync("Game");
        }


        private void OnDisable()
        {
            UIEvents.OnStartBtnClick.RemoveListener(StartBtnHandler);
        }
    }
}