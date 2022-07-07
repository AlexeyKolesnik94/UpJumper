using UnityEngine;
using UnityEngine.UI;

namespace Score
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private Text textScore;

        public void RenderCount(int count)
        {
            textScore.text = "score: " + count;
        }
    }
}