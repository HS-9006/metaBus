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
            Debug.Log("�̴ϰ��� ���� ������ ���Խ��ϴ�!");
            // MiniGameScene ����
            SceneManager.LoadScene("MiniGameScene"); 
        }
    }
}
