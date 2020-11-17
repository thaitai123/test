using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject.tag == "NoteStart" && ScreenMovement.instance != null)
            {
                ScreenMovement.instance.speed = 5;
                ScreenMovement.instance.isStartGame = true;
                hit.collider.gameObject.SetActive(false);
               
            }
        }
    }
}
