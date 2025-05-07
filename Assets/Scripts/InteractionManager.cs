using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public static InteractionManager Instance;
    private void Awake() => Instance = this;

    private Vector2 PlayerPosition => GameObject.FindWithTag("Player").transform.position;
    private Vector2 PlayerDirection => Vector2.right; 
}
