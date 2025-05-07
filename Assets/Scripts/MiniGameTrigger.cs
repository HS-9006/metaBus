using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("미니게임 시작 구역에 들어왔습니다!");
            // MiniGameScene 설정
            SceneManager.LoadScene("MiniGameScene"); 
        }
    }
}
