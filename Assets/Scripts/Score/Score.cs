using UniRx;
using UnityEngine;

namespace Score
{
    public class Score : MonoBehaviour
    {
        public ReactiveProperty<int> GameScore { get; private set; }

        public Score()
        {
            GameScore = new ReactiveProperty<int>(0);
        }
    }
}
