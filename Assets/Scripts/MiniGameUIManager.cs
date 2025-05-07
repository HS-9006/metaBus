using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiniGameUIManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;
    public TextMeshProUGUI highScoreText;
    void Start()
    {
        if (restartText == null)
            Debug.Log("restart text is null");

        if (scoreText == null)
            Debug.Log("score text is null");
        
        restartText.gameObject.SetActive(false);
    }


    public void SetRestart(int score, int highScore)
    {
        restartText.text = "Game Over!\nScore: " + score;
        highScoreText.text = "High Score: " + highScore;
        restartText.gameObject.SetActive(true);
        highScoreText.gameObject.SetActive(true);
    }

    public void updateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
