using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("asd");
        if (collision.gameObject.GetComponent<FlappyBird>())
        {
            ScoreManager.Instance.UpdateScore();
            
        }
    }
}
