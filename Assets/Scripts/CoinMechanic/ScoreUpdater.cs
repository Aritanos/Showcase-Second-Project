using UnityEngine;
using System;

namespace TestProject.CoinSystem
{
    public class ScoreUpdater : MonoBehaviour
    {
        public static event Action<int> UpdateScore;

        protected void InvokeScoreUpdate(int score)
        {
            UpdateScore?.Invoke(score);
        }
    }
}


