using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSponse : MonoBehaviour
{
    public static BrickSponse instanse;

    private Queue<GameObject> trailQueue = new Queue<GameObject>();

    [SerializeField]
    public GameObject[] note;

    public int noteNumber = 0;

    List<float> randomY = new List<float>() {-2.15f, -0.65f, 0.65f, 2.15f};

    // Start is called before the first frame update
    void Awake()
    {
        brickSponseInstanse();
        float y = 3f;

        for (int i = 0; i < note.Length; i++)
        {
            Vector3 vector = transform.position;
            vector.x = randomY[Random.RandomRange(0, 4)];
            y += 3f;
            vector.y = y;

            note[i].tag = "Note";
            Instantiate(note[i], vector, Quaternion.identity);
        }
    }


    void brickSponseInstanse()
    {
        if (instanse == null)
        {
            instanse = this;
        }
    }

}
