using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieseRotater : MonoBehaviour
{
    //��]����l����� 
    float rotValue;
    //�{�^���������ꂽ���o����g���K�[
    bool isPushButton;

    // Start is called before the first frame update
    void Start()
    {
        //�n�܂����u�Ԃ͉�����Ă��Ȃ��̂Ńg���K�[�́u�U�v
        isPushButton = false;

        rotValue = -20;

        this.transform.Rotate(0, 0, rotValue);

    }

    // Update is called once per frame
}
