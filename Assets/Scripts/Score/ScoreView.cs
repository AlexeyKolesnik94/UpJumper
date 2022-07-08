using TMPro;
using UnityEngine;

namespace Score
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textScore;

        public void RenderCount(int count)
        {
            textScore.text = "score: " + count;
        }
    }
}