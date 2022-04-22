using UnityEngine;
using System;

public class ScoreUpdater : MonoBehaviour
{
    //public event Action<int> UpdateScore;
    public static event Action<int> UpdateScore;

    protected void InvokeScoreUpdate(int score)
    {
        UpdateScore?.Invoke(score);
    }
}

