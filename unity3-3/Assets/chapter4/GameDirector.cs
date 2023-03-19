using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI�� ����ϴ� �� �ʿ��ϴ�

public class GameDirector : MonoBehaviour
{
    CarController carController;
    GameObject car;
    GameObject flag;
    GameObject distanceText;
    public bool status = true;

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distanceText = GameObject.Find("Distance");

        carController = car.GetComponent<CarController>();
    }

    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        this.distanceText.GetComponent<Text>().text = "��ǥ �������� " + length.ToString("F2") + "m";
    }
}
