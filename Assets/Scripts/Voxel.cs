// 복셀이 랜덤한 방향으로 날아가는 운동을 한다

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

    // after scheduled time, destroy voxel

    // time for destroy voxel
    public float destroyTime = 3.0f;
    float currentTime;
    void Update()
    {
        // 1. a few moment later
        currentTime = Time.deltaTime;
        // 2. time to destroy
        if (currentTime > destroyTime)
        {
            // destroy voxel
            Destroy(gameObject);
        }
    }
}
