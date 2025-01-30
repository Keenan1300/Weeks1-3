using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EarthSpin : MonoBehaviour
{
    float speed = 1.2f;
 
    // Update earth Every Frame so that it consistently rotates to appear real
    
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
