// ?????? ?????? ???????? ???????? ?????? ????

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voxel : MonoBehaviour
{
    // 1. voxel's speed
    public float speed = 5;
    /*
     void Start()
     
         // 2. find random
         Vector3 direction = Random.insideUnitSphere;
         // 3. set random speed
         Rigidbody rb = gameObject.GetComponent<Rigidbody>();
         rb.velocity = direction * speed;
     }
    */
    void OnEnable()
    {
        currentTime = 0;
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
            /*
             // destroy voxel
             Destroy(gameObject);
            */
            // 3. inactive voxel
            gameObject.SetActive(false);
            // 4. reput into object pool
            VoxelMaker.voxelPool.Add(gameObject);
        }
    }
}
