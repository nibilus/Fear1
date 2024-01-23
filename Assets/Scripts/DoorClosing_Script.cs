using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClosing_Script : MonoBehaviour{
    public GameObject TheDoor;
    public AudioSource DoorCreaky;
    public AudioSource LaughWoman;
    public AudioSource HitDark;

    void OnTriggerEnter(){
        GetComponent<BoxCollider>().enabled = false;
        TheDoor.GetComponent<Animation>().Play("DoorClosing_Anim");
        DoorCreaky.Play();
        LaughWoman.Play();
        HitDark.Play();
    }
}
