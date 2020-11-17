using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadController : MonoBehaviour
{
    private void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            DeadNoteController.instance.transform.position = collision.gameObject.transform.position;
            ScreenMovement.instance.speed = -2;

            Debug.Log("Trigger Dead event");
            StartCoroutine(StopEvent());
        }
    }

    IEnumerator StopEvent()
    {
        yield return new WaitForSeconds(1.7f);
        Vector3 vector = new Vector3(12.54f, 0.03f, 0);
        DeadNoteController.instance.transform.position = DeadNoteController.instance.transform.position + vector;
        ScreenMovement.instance.speed = 0;
        ScreenMovement.instance.isPauseGame = true;
        Debug.Log("Stop Dead event");
    }

}
