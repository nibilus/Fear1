using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildWhisper : MonoBehaviour
{
    public AudioSource ChildWhispers;
    
    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        ChildWhispers.Play();
        
    }
}
