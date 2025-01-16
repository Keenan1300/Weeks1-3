using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingArm : MonoBehaviour
{
    float armspeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rot = transform.rotation;
        rot.z -= armspeed;
        transform.rotation = rot;
        if (rot.z == -180 )
        {
            rot.z = rot.z*-1;
        }
    }
}
