using Unity.VisualScripting;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            Vector3 pos = transform.position;
            pos.x += speed * Time.deltaTime;

            Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

            if (squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
            {
                Vector3 fixedPos = new Vector3(0, 0, 0);
                pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
                speed = speed * -1;
            }

            transform.position = pos;
        }
    }
}