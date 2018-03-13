﻿using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class smart_zombie_movement : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}