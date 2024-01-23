using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryWomanScript : MonoBehaviour
{
    public AudioSource HorrificMusic;
    public GameObject TheDoor;
    public AudioSource DoorOpen;
    public AudioSource TheMonster;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheDoor.GetComponent<Animation>().Play("DoorOpen_Anim");
        HorrificMusic.Play();
        DoorOpen.Play();
        TheMonster.Play();
    }
}
