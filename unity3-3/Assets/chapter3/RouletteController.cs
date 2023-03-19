using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;  // ȸ�� �ӵ�  

    void Start()
    {
    }

    void Update()
    {
        // Ŭ���ϸ� ȸ�� �ӵ��� �����Ѵ�
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��
        transform.Rotate(0, 0, this.rotSpeed);

        // �귿�� ���ӽ�Ų��(�߰�)
        this.rotSpeed *= 0.96f;
        if (Input.GetMouseButton(0))
        {
            Debug.Log("���콺 Ŭ�� �Էµ�");
            rotSpeed += 10;
        }

        transform.Rotate(0, 0, rotSpeed); // ȸ���ӵ���ŭ �귿�� ȸ����Ŵ
        rotSpeed *= 0.992f;

        if (rotSpeed < 0.01f && rotSpeed != 0)
        {

            // Debug.Log($"{transform.rotation.eulerAngles.z}");

            if (transform.rotation.eulerAngles.z % 360 + 30 <= 60)
                Debug.Log("��� ����");
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 120)
                Debug.Log("��� ����");
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 180)
                Debug.Log("��� �ſ� ����");
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 240)
                Debug.Log("��� ����");
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 300)
                Debug.Log("��� ����");
            else
                Debug.Log("��� ����");

            rotSpeed = 0;
        }
    }
}
