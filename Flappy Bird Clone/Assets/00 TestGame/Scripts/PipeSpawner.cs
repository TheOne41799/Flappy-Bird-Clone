using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.45f;

    [SerializeField] private GameObject pipePrefab;

    private float timer;


    private void Start()
    {
        SpawnPipe();
    }


    private void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }


    private void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, UnityEngine.Random.Range(-heightRange, heightRange), 0);
        GameObject pipe = Instantiate(pipePrefab, spawnPosition, quaternion.identity);

        Destroy(pipe, 10f);
    }
}







