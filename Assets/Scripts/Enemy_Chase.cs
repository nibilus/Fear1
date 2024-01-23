﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Chase : MonoBehaviour{

    private NavMeshAgent myAgent;
    public Transform target;

    void Start(){
        myAgent = GetComponent<NavMeshAgent>();
    }

    void Update(){
        myAgent.SetDestination(target.position);
    }
}
