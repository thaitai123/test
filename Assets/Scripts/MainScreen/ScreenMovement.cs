using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMovement : MonoBehaviour
{
    public static ScreenMovement instance;
    public float speed;
    public bool isStartGame;
    public bool isPauseGame;
    public bool isEndGame;

    // Start is called before the first frame update
    void Awake()
    {
        isStartGame = false;
        isPauseGame = false;
        isEndGame = false;
        speed = 0;
        makeInstance();
    }

    void makeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        dropdown();
    }

    void dropdown()
    {
        Vector3 vector = transform.position;
        vector.y += speed * Time.deltaTime;
        transform.position = vector;
    }
    
}
