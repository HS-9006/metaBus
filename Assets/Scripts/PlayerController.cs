using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 입력 처리
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = movement.normalized;

    }

    void FixedUpdate()
    {
        // 물리 기반 이동
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        // (선택) 화면 밖 이동 제한
        ClampToMapBounds();
    }
    void ClampToMapBounds()
    {
        Vector3 clamped = transform.position;

        // 예시로 화면 좌우 10, 상하 5로 제한
        clamped.x = Mathf.Clamp(clamped.x, -10f, 10f);
        clamped.y = Mathf.Clamp(clamped.y, -5f, 5f);

        transform.position = clamped;
    }
}
