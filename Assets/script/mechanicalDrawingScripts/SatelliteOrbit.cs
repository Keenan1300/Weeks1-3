using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SatelliteOrbit : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    public AnimationCurve curve;
    public Transform start;
    public Transform end;

    float speed = 4;

    // Update is called once per frame
    void Update()
    {
        //satellite rotates on its own time
        transform.Rotate(0, 0, speed * Time.deltaTime);

        //Satellite Orbits Earth
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
