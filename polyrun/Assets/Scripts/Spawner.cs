﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("ChallengeObj Game Object")]
    public GameObject challengeObject;
    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 1f;
    [Header("Default Spawn Time")]
    public float spawnTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
    }

    void InstantiateObjects()
    {
        Instantiate(challengeObject, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
