using UnityEngine.Events;

namespace SupportScripts
{
    public static class LoseEvent
    {
        public static readonly UnityEvent OnLoseGame = new UnityEvent();

        public static void SendLoseGame()
        {
            OnLoseGame.Invoke();
        }
    }
}