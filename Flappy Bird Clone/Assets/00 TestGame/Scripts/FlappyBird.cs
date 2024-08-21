using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    [SerializeField] private float velocity = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;

    private Rigidbody2D flappyBirdRB;


    private void Start()
    {
        flappyBirdRB = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           flappyBirdRB.velocity = Vector2.up * velocity;
        }
    }


    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, flappyBirdRB.velocity.y * rotationSpeed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
    }
}
