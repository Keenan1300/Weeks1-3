using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UFOBuzzing : MonoBehaviour
{

    float speed = 3;

    // Update is called once per frame
    void Update()
    {

        Vector3 rot = transform.eulerAngles;
        rot.z += speed;
        transform.eulerAngles = rot;

        if ( rot.z < -60 || rot.z > 60)
        {
            speed = speed * -1;
        }

    }
}
