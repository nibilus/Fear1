using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVPlay : MonoBehaviour
{
    public AudioSource TVSource;
    public AudioSource HitDrama;
    public GameObject TVScreen;
    public GameObject BlockWall;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TVScreen.SetActive(true);
        TVSource.Play();
        HitDrama.Play();
        StartCoroutine(StopSounds());
        BlockWall.SetActive(true);

    }

    IEnumerator StopSounds()
    {
        yield return new WaitForSeconds(10);
        TVScreen.SetActive(false);
        TVSource.Stop();
    }
}

