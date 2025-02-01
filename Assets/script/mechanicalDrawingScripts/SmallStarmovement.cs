using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SmallStarmovement : MonoBehaviour
{
    //set location points for manual shooting star system that uses left click. 
    [Range(0, 10)]
    public float t;
    public Vector2 PointA;
    public Vector2 PointB;


    // Update is called once per frame
    void Update()
    {
        //This code will allow a shooting star in the background to move across the screen. 

        transform.position = Vector2.Lerp(PointA, PointB, t);

        if (Input.GetMouseButtonDown(0))
        {
            t = t + 1;
        } 
    }
    }

