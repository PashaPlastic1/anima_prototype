using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float m_speed;
    private Rigidbody2D m_rb;
    private Vector2 m_moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        m_moveVelocity = moveInput.normalized * m_speed;
    }

    void FixedUpdate()
    {
        m_rb.MovePosition(m_rb.position + (m_moveVelocity * Time.fixedDeltaTime));
    }
}
