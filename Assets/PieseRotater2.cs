using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieseRotater2 : MonoBehaviour
{
    //��]����l����� 
    float rotValue;
    //�{�^���������ꂽ���o����g���K�[
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

            //�{�^���������ꂽ�������m����B

        if (isPushButton)
        {
            this.transform.Rotate(0, 0, rotValue);
        }

    }
}
