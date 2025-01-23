using Unity.VisualScripting;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.9f;

    public SpriteRenderer spriteRenderer;
    public Sprite sprite;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.color = Random.ColorHSV();
        spriteRenderer.sprite = sprite;
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