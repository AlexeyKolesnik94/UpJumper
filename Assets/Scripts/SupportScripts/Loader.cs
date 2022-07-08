using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SupportScripts
{
    public class Loader : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textLoading;
        [SerializeField] private string sceneName;
        
        private AsyncOperation _asyncOperation;

        private void Start()
        {
            StartCoroutine(LoadStartCoroutine());
        }

        IEnumerator LoadStartCoroutine()
        {
            yield return new WaitForSeconds(1);
            _asyncOperation = SceneManager.LoadSceneAsync(sceneName);

            while (!_asyncOperation.isDone)
            {
                float progress = _asyncOperation.progress / 0.9f;
                textLoading.text = $"LOADING {progress * 100f}%";
                yield return 0;
            }
        }
    }
}
