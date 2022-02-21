using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelMaker : MonoBehaviour
{
    // voxel factory
    public GameObject voxelFactory;
    // size of object pool
    public int voxelPoolSize = 20;
    // object pool
    public static List<GameObject> voxelPool = new List<GameObject>();

    void Start()
    {
        // put inactiving voxel into object pool
        for (int i = 0; i < voxelPoolSize; i++)
        {
            // 1. create voxel from voxelFactory
            GameObject voxel = Instantiate(voxelFactory);
            // 2. inactive voxel
            voxel.SetActive(false);
            // 3. put voxel into object pool
            voxelPool.Add(voxel);
        }
    }

    // creation time
    public float creatTime = 0.1f;
    // current time
    float currentTime = 0;

    void Update()
    {
        // 0. pass current time
        currentTime += Time.deltaTime;
        // 1. if click mouse -> if current time has exceeded creation time
        if (currentTime > creatTime)
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo = new RaycastHit();

            // 2. if mouse locates on the floor
            if (Physics.Raycast(ray, out hitInfo))
            {
                /*
                // 3. make voxel from voxelmaker
                GameObject voxel = Instantiate(voxelFactory);
                // 4. place voxel
                voxel.transform.position = hitInfo.point;
                */

                // use object pool
                // 1. if exist voxel in object pool
                if (voxelPool.Count > 0)
                {
                    // init current time while create voxel
                    currentTime = 0;

                    // 2. take one voxel from object pool
                    GameObject voxel = voxelPool[0];
                    // 3. activate voxel
                    voxel.SetActive(true);
                    // 4. place voxel
                    voxel.transform.position = hitInfo.point;
                    // 5. remove voxel from object pool
                    voxelPool.RemoveAt(0);
                }
            }
        }
    }
}
