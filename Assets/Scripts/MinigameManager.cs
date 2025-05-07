using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameManager : MonoBehaviour
{

    static MinigameManager minigameManager;
    public static MinigameManager Instance { get { return minigameManager; } }

    private int currentScore = 0;

    private int highScore = 0;

    MiniGameUIManager uiManager;

    public void Awake()
    {
        minigameManager = this;
        uiManager = FindObjectOfType<MiniGameUIManager>();
    }

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        uiManager.updateScore(currentScore);
    }

    public void GameOver()
    {
        Debug.Log("game over");
        //uiManager.SetRestart();
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log("Score : " + currentScore);
        uiManager.updateScore(currentScore);
    }

    public void ReturnToMainMap()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

}
