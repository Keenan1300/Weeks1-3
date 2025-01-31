using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starpulse : MonoBehaviour
{ 
    //introduce animation curve so that the center of the shooting appears moves in quick patterns, like a pulse 
    public AnimationCurve pulse;

    [Range(0, 1)]
    public float P;

    // Update is called once per frame
    void Update()
    {
        //Make it so the value P, the pulse, is added to the Time variable. Once this value is over 1, make it so P sets back to 0.
        //This will make the star appear like it is pulsing.
        P = P + Time.deltaTime;
        if(P > 1)
        {
         P = 0;
        }
        transform.localScale = Vector2.one * pulse.Evaluate(P);
    }
}
