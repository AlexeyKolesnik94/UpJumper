using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public abstract class ButtonSender : MonoBehaviour
    {
        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(BtnSender);
        }

        protected abstract void BtnSender();
    }
}