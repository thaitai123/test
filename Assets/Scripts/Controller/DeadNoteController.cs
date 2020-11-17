using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadNoteController : MonoBehaviour
{

    public static DeadNoteController instance;
    
    // Start is called before the first frame update
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
}
