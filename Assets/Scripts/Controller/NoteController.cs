using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    public static NoteController instance;
    // Start is called before the first frame update
    List<float> randomeY = new List<float>() { -2.15f, -0.65f, 0.65f, 2.15f };
    int y = 60;
    int i = 0;

    void Awake()
    {
        makeInstance();
    }

    void makeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject.tag == "Note")
            {
                Vector3 vector = transform.position;
                vector.x = randomeY[Random.RandomRange(0, 4)];
                y += 3;
                vector.y = y;
                hit.collider.gameObject.transform.position = vector;
                i++;
                Debug.Log("Note move to position" + i);
                //hit.collider.name;
            }

            //if (hit.collider == null)
            //{
                //ScreenMovement.instance.speed = 0;
                //Debug.Log("Trigger Speed is 0");
            //}
        }

    }
}
