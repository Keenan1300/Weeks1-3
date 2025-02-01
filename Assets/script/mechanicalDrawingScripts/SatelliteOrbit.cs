using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SatelliteOrbit : MonoBehaviour
{
  


    float speed = 0.02f;

    // Update is called once per frame
    void Update()
    {
        //This code will make the Satellite rotate based on its pivot point (positioned at the center of earth), at a frequent rate. 
        Vector3 rot = transform.eulerAngles;
        rot.z += speed;
        transform.eulerAngles = rot;
    }
}
