using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOlocation : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        //This code places the location of the UFO to the player mouse.

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
        
    }
}
