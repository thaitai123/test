using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currencyHeader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Vector3 tempScale = transform.localScale;
        Vector3 positionScale = transform.position;

        float worldHeight = Camera.main.orthographicSize * 2f;
        float height = spriteRenderer.bounds.size.y;

        float worldWidth = worldHeight * Screen.width / Screen.height;
        float width = spriteRenderer.bounds.size.x;

        positionScale.y = 5f - 1f / 2f;
        positionScale.x = 0;
        tempScale.y = (worldHeight / height) * 10 /100;
        tempScale.x = worldWidth / width;

        transform.localScale = tempScale;
        transform.position = positionScale;
    }
}
