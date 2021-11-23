using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Player player;
    public float m_resetTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.m_holdingBall == false)
        {
            m_resetTimer -= Time.deltaTime;
            if (m_resetTimer <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
