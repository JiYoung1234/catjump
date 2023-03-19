using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isBlink = false;
    float time = 0;
    bool isOn = false;
    int blinkCount = 0;
    SpriteRenderer spriteRenderer;


    public float speed = 5f;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        // ���� ȭ��ǥ�� ������ ��
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Translate(-speed * Time.deltaTime, 0, 0); // �������� ��1�� �����δ�
        }

        // ������ ȭ��ǥ�� ������ ��
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(+speed * Time.deltaTime, 0, 0); // ���������� ��1�� �����δ�
        }


        if (Input.GetKeyDown(KeyCode.K))
        {
            isBlink = true;
        }
        if (isBlink)
        {
            time += Time.deltaTime;
            if(time > 0.5f)
            {
                time = 0;
                spriteRenderer.enabled = isOn;
                isOn = !isOn;
                blinkCount++;
            }
        }
        if (blinkCount > 5)
        {
            isBlink = false;
            time = 0;
            isOn = false;
            blinkCount = 0;
        }

    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }


}