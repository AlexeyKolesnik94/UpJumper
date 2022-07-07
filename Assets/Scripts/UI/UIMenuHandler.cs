using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class UIMenuHandler : MonoBehaviour
    {
        private void Start()
        {
            UIEvents.OnStartBtnClick.AddListener(StartBtnHandler);
        }

        private void StartBtnHandler()
        {
            SceneManager.LoadScene("Game");
        }
    }
}