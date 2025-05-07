using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int totalScore = 0;

    private void Awake() => Instance = this;

    public void RecordScore(int score)
    {
        totalScore += score;
        Debug.Log($"ÃÑ Á¡¼ö: {totalScore}");
    }
}
