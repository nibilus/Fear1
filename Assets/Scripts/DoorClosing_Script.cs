using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClosing_Script : MonoBehaviour{

    public AudioSource DoorCreaky;
    public Collider PlayerCollider;
    //public AudioSource LaughWoman;
    //public AudioSource HitDark;
    // public Animation OpenClose;
    private void Start()
    {
        //GetComponent<Animation>().enabled = false;
    }

    void OnTriggerEnter(Collider PlayerCollider){
        //GetComponent<BoxCollider>().enabled = false;
        //GetComponent<Animation>().enabled = true;
        GetComponent<Animation>().Play();
        DoorCreaky.Play();
        //LaughWoman.Play();
        //HitDark.Play();
    }
}
