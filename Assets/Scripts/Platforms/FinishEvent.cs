using UnityEngine.Events;

namespace Platforms
{
    public static class FinishEvent
    {
        public static readonly UnityEvent OnFinishing = new UnityEvent();

        public static void SendFinishing()
        {
            OnFinishing.Invoke();
        }
        
    }
}