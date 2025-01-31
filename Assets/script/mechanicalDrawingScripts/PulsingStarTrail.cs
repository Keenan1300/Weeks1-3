using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsingStarTrail : MonoBehaviour
{
    //introduce animation curve so that the trail of the shooting star is moving subtly to recreate a visual comet effect. 
    public AnimationCurve trail;

    [Range(0, 1)]
    public float T;
    public float H;

    // Update is called once per frame
    void Update()
    {
        //Make it so the value T, the trail, is added to the Time variable. Once this value is over 1, make it so T sets back to 0.
        //This will make the star appear like it is moving. The shape will be frequently scaled at subtle rates compared to the star pulse to create depth.
        T = T + Time.deltaTime;
        if (T > 1)
        {
            T = 0;
        }
        transform.localScale = Vector2.one * trail.Evaluate(T);


        //I want the x scale of the star trail to shrink and grow faster than the other axis's of the shape. This will add to the trial effect, by elongating the shape
        //To do this, Linear interpolation will be added to shrink and grow precisely the x axis. This will be done with the float variable H.

        H = H + Time.deltaTime;
        if (H > 50)
        {
            H = 0;
        }

        Vector2 scale = transform.localScale;
        scale.x = Mathf.Lerp(0, 60, H);



    }
}
