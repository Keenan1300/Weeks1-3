using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EarthSpin : MonoBehaviour
{
    //Basic Script that will make the Earth move to make it seem active. 

    //set rotation speed per frame.
    float speed = 0.01f;
    
 
    // Updates earth Every frame so that it consistently rotates
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += speed;
        transform.eulerAngles = rot;
    }
}
