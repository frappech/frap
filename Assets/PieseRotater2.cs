using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieseRotater2 : MonoBehaviour
{
    //回転する値を入力 
    float rotValue;
    //ボタンが押されたを覚えるトリガー
    bool isPushButton;

    // Start is called before the first frame update
    void Start()
    {
        isPushButton = false;

        rotValue = -20;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPushButton = true;
        }

    }
    void FixedUpdate()
    {

            //ボタンが押されたかを検知する。

        if (isPushButton)
        {
            this.transform.Rotate(0, 0, rotValue);
        }

    }
}
