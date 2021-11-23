using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject m_ball;
    public GameObject m_playerCamera;
    public float m_ballDistance = 2.25f;
    public float m_ballThrowFroce = 500f;

    public bool m_holdingBall = true;
    Rigidbody m_BallRigidbody;
    
    void Start()
    {
        m_BallRigidbody = m_ball.GetComponent<Rigidbody>();
        m_BallRigidbody.useGravity = false;
    }

    
    void Update()
    {
        if (m_holdingBall)
        {
            m_ball.transform.position = m_playerCamera.transform.position + m_playerCamera.transform.forward * m_ballDistance;

            if (Input.GetMouseButtonDown(0))
            {
                m_holdingBall = false;
                m_BallRigidbody.useGravity = true;
                m_BallRigidbody.AddForce(m_playerCamera.transform.forward * m_ballThrowFroce);
            }
        }
    }
}
