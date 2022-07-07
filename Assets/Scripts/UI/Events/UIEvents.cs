using UnityEngine.Events;

namespace UI.Events
{
    public static class UIEvents
    {
        public static readonly UnityEvent OnMenuBtnClick = new UnityEvent();
        public static readonly UnityEvent OnRestartBtnClick = new UnityEvent();
        public static readonly UnityEvent OnResumeBtnClick = new UnityEvent();
        
        public static readonly UnityEvent OnPauseBtnClick = new UnityEvent();
        
        public static readonly UnityEvent OnStartBtnClick = new UnityEvent();



        public static void SendMenuBtnClick()
        {
            OnMenuBtnClick.Invoke();
        }
        
        public static void SendRestartBtnClick()
        {
            OnRestartBtnClick.Invoke();
        }
        
        public static void SendResumeBtnClick()
        {
            OnResumeBtnClick.Invoke();
        }
        
        public static void SendPauseBtnClick()
        {
            OnPauseBtnClick.Invoke();
        }
        
        public static void SendStartBtnClick()
        {
            OnStartBtnClick.Invoke();
        }
    }
}
