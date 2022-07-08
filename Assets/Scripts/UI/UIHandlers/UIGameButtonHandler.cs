using UI.Events;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.UIHandlers
{
    public class UIGameButtonHandler : MonoBehaviour
    {
        [SerializeField] private Canvas pauseCanvas;
        
        
        private void Start()
        {
            UIEvents.OnMenuBtnClick.AddListener(MenuBtnHandler);
            UIEvents.OnRestartBtnClick.AddListener(RestartBtnHandler);
            UIEvents.OnResumeBtnClick.AddListener(ResumeBtnHandler);
            
            UIEvents.OnPauseBtnClick.AddListener(PauseBtnHandler);
        }

        private void MenuBtnHandler()
        {
            SceneManager.LoadSceneAsync("Loader");
            Time.timeScale = 1;
        }
        
        private void RestartBtnHandler()
        {
            SceneManager.LoadSceneAsync("Game");
            Time.timeScale = 1;
        }
        
        private void ResumeBtnHandler()
        {
            pauseCanvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }

        private void PauseBtnHandler()
        {
            pauseCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        
        
        private void OnDisable()
        {
            UIEvents.OnMenuBtnClick.RemoveListener(MenuBtnHandler);
            UIEvents.OnRestartBtnClick.RemoveListener(RestartBtnHandler);
            UIEvents.OnResumeBtnClick.RemoveListener(ResumeBtnHandler);
            
            UIEvents.OnPauseBtnClick.RemoveListener(PauseBtnHandler);
        }

    }
}