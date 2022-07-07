using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Score
{
    public class ScorePresenter : MonoBehaviour
    {
        [SerializeField] private Transform transformScoring;
        [SerializeField] private ScoreView scoreView;
        
        private Score _score = new Score();

        private void Start()
        {
            transformScoring.ObserveEveryValueChanged(x => x.position.y)
                .Subscribe(x =>
                {
                    _score.GameScore.Value += (int)x;
                }).AddTo(this);

            _score.GameScore.Subscribe(_ =>
            {
                scoreView.RenderCount(_score.GameScore.Value);
                
            }).AddTo(this);
        }
    }
}

