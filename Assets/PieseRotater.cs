using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieseRotater : MonoBehaviour
{
    //回転する値を入力 
    float rotValue;
    //ボタンが押されたを覚えるトリガー
    bool isPushButton;

    // Start is called before the first frame update
    void Start()
    {
        //始まった瞬間は押されていないのでトリガーは「偽」
        isPushButton = false;

        rotValue = -20;

        this.transform.Rotate(0, 0, rotValue);

    }

    // Update is called once per frame
}
