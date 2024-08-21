using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float width = 6f;

    private SpriteRenderer groundSpriteRenderer;
    private Vector2 startSize;


    private void Start()
    {
        groundSpriteRenderer = GetComponent<SpriteRenderer>();
        startSize = new Vector2(groundSpriteRenderer.size.x, groundSpriteRenderer.size.y);
    }


    private void Update()
    {
        groundSpriteRenderer.size = new Vector2(groundSpriteRenderer.size.x + speed * Time.deltaTime, groundSpriteRenderer.size.y);

        if(groundSpriteRenderer.size.x > width )
        {
            groundSpriteRenderer.size = startSize;
        }
    }
}
