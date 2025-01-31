using Unity.VisualScripting;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public float speed = 10f;


    // Update is called once per frame
    void Update()
    {
        {
            Vector3 pos = transform.position;
            pos.x += speed * Time.deltaTime;

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