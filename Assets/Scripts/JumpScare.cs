using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject TheEnemy;
    public AudioSource BrokenGlass;
    public AudioSource EnemyGrr;
    public AudioSource HitStress;
    public GameObject BlockWall;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheEnemy.SetActive(true);
        BrokenGlass.Play();
        EnemyGrr.Play();
        //HitStress.Play();
        StartCoroutine(HitStres());
        StartCoroutine(Monster());
        BlockWall.SetActive(true);
    }

    IEnumerator HitStres(){
        yield return new WaitForSeconds(0.50f);
        HitStress.Play();
    }

    IEnumerator Monster(){
        yield return new WaitForSeconds(4);

        TheEnemy.SetActive(false);
    }
}
