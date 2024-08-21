using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float pipeSpeed = 0.65f;


    private void Update()
    {
        transform.position +=  pipeSpeed * Time.deltaTime * Vector3.left;
    }
}
