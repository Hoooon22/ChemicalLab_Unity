// 마우스 입력에 따라 카메라 회전
// 필요 속성 : 현재 각도, 마우스 감도

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
        // 1. get mouse input
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        // 2. accumulate rotation value for each attribute to put it in moblie formula
        angle.x += x * sensitivity * Time.deltaTime;
        angle.y += y * sensitivity * Time.deltaTime;

        // 3. allocate new rotate value to camera rotate value
        transform.eulerAngles = new Vector3(-angle.y, angle.x, transform.eulerAngles.z);
    }
}
