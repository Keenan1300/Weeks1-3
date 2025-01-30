using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EarthSpin : MonoBehaviour
{
    float speed = 0.01f;
    
 
    // Update earth Every Frame so that it consistently rotates to appear real
    
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += speed;
        transform.eulerAngles = rot;
    }
}
