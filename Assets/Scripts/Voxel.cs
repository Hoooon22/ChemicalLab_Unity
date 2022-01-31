// ������ ������ �������� ���ư��� ��� �Ѵ�

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voxel : MonoBehaviour
{
    // 1. voxel's speed
    public float speed = 5;

    void Start()
    {
        // 2. find random
        Vector3 direction = Random.insideUnitSphere;
        // 3. set random speed
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = direction * speed;
    }

    void Update()
    {
        // after scheduled time, delete voxel
        
    }
}
