// ���콺 �Է¿� ���� ī�޶� ȸ��
// �ʿ� �Ӽ� : ���� ����, ���콺 ����

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    // current angle
    Vector3 angle;
    // mouse sensitivity
    public float sensitivity = 200;

    void Start()
    {
        // apply current angle when program start
        angle.y = -Camera.main.transform.eulerAngles.x;
        angle.x = Camera.main.transform.eulerAngles.y;
        angle.z = Camera.main.transform.eulerAngles.z;
    }

    void Update()
    {
        
    }
}
