using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController2 : MonoBehaviour
{
    GameObject player1;
    GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.Find("player");
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.01f, 0);
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;
        Vector2 p2 = player1.transform.position;
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;

        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            gameManager.GetComponent<GameManager2>().DecreaseHP();
            player1.GetComponent<PlayerController>().isBlink = true;
            Debug.Log("´ê¾Ò´Ù");
            Destroy(gameObject);
        }
    }
}
