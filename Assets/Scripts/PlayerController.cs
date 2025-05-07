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
        // �Է� ó��
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = movement.normalized;

    }

    void FixedUpdate()
    {
        // ���� ��� �̵�
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        // (����) ȭ�� �� �̵� ����
        ClampToMapBounds();
    }
    void ClampToMapBounds()
    {
        Vector3 clamped = transform.position;

        // ���÷� ȭ�� �¿� 10, ���� 5�� ����
        clamped.x = Mathf.Clamp(clamped.x, -10f, 10f);
        clamped.y = Mathf.Clamp(clamped.y, -5f, 5f);

        transform.position = clamped;
    }
}
