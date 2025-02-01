using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UFOBuzzing : MonoBehaviour
{
    //This script is to make the UFO ship more playful as it follows the player mouse. The script will make the UFO buzz or wobble as it hovers over the player mouse.

    float speed = 3;

    // Update is called once per frame
    void Update()
    {
        //this code makes the UFO rotate. Once it goes too far in one direction of rotation, it will rotate the other way.
        Vector3 rot = transform.eulerAngles;
        rot.z += speed;
        transform.eulerAngles = rot;

        if ( rot.z < -60 || rot.z > 60)
        {
            speed = speed * -1;
        }

    }
}
