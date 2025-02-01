using Unity.VisualScripting;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    //This script is to make a shooting star that will continually shoot accross the screen, from the left to the right.

    //variable to control speed
    public float speed = 10f;


    // Update is called once per frame
    void Update()
    {
        //Connect star to time so that it moves with each frame.
        {
            Vector3 pos = transform.position;
            pos.x += speed * Time.deltaTime;

            //This code ensures that the shooting star will reset to the left of the screen once it leaves the camera frame.
            Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

            if (squareInScreenSpace.x > Screen.width)
            {
                Vector3 fixedPos = new Vector3(0,0,0);
                pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            }

            transform.position = pos;
        }
    }
}