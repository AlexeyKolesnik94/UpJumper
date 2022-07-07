using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
    public class UIButtonHandler : MonoBehaviour
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
            SceneManager.LoadScene("MainMenu");
            Time.timeScale = 1;
        }
        
        private void RestartBtnHandler()
        {
            SceneManager.LoadScene("Game");
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
    }
}