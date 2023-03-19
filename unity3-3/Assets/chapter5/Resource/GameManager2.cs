using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    GameObject hpGauage;
    // Start is called before the first frame update
    void Start()
    {
        hpGauage = GameObject.Find("hpGauage");
    }

    // Update is called once per frame
    public void DecreaseHP()
    {
        hpGauage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
