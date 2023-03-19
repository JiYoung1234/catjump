using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;  // 회전 속도  

    void Start()
    {
    }

    void Update()
    {
        // 클릭하면 회전 속도를 설정한다
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // 회전 속도만큼 룰렛을 회전시킨다
        transform.Rotate(0, 0, this.rotSpeed);

        // 룰렛을 감속시킨다(추가)
        this.rotSpeed *= 0.96f;
        if (Input.GetMouseButton(0))
        {
            Debug.Log("마우스 클릭 입력됨");
            rotSpeed += 10;
        }

        transform.Rotate(0, 0, rotSpeed); // 회전속도만큼 룰렛을 회전시킴
        rotSpeed *= 0.992f;

        if (rotSpeed < 0.01f && rotSpeed != 0)
        {

            // Debug.Log($"{transform.rotation.eulerAngles.z}");

            if (transform.rotation.eulerAngles.z % 360 + 30 <= 60)
                Debug.Log("운수 나쁨");
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 120)
                Debug.Log("운수 대통");
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 180)
                Debug.Log("운수 매우 나쁨");
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 240)
                Debug.Log("운수 보통");
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 300)
                Debug.Log("운수 조심");
            else
                Debug.Log("운수 좋음");

            rotSpeed = 0;
        }
    }
}
