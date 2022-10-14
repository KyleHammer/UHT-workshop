using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;

    public void AddScore(int increaseAmount)
    {
        score += increaseAmount;
        scoreText.text = "Score: " + score;
    }
}
