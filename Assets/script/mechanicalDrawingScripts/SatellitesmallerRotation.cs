using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatellitesmallerRotation : MonoBehaviour
{

    float speed = -0.02f;

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += speed;
        transform.eulerAngles = rot;
    }
}
