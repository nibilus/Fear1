using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalkTrigger : MonoBehaviour
{
    public GameObject TheEnemy;
    public AudioSource EnemyGrr;
    public AudioSource Footstep;
    public GameObject BlockWall;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheEnemy.SetActive(true);
        EnemyGrr.Play();
        Footstep.Play();
        BlockWall.SetActive(true);
    }
}