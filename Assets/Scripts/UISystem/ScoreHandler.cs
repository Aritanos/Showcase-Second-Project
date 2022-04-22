using UnityEngine;
using TestProject.CoinSystem;

namespace TestProject.UISystem
{
    public class ScoreHandler : MonoBehaviour
    {
        [SerializeField] TMPro.TMP_Text _scoreText;

        private int _currentScoreAmount = 0;

        void Start()
        {
            ScoreUpdater.UpdateScore += UpdateScore;
        }

        public void UpdateScore(int scoreAmount)
        {
            _currentScoreAmount += scoreAmount;
            _scoreText.text = _currentScoreAmount.ToString();
        }
    }
}
