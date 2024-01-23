using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackInTheBox : MonoBehaviour
{
    public GameObject Jack;
    public AudioSource JackLaugh;
    public AudioSource HitDrama;
    public GameObject BlockWall;


    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        Jack.SetActive(true);
        Jack.GetComponent<Animation>().Play("JackInTheBox_Anim");
        JackLaugh.Play();
        HitDrama.Play();
        BlockWall.SetActive(true);


    }
}
