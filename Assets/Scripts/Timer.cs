using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 91f;
    public GameObject EndScreen;

    void Start()
    {
        StartCoroutine(Timer1());
    }

    private IEnumerator Timer1()
    {
        do
        {
            timer -= Time.deltaTime;
            FormatText1();
            yield return null;
        }
        while (timer > 0);
    }

    public void FormatText1()
    {
        int minutes = (int)(timer / 60) % 60;
        int seconds = (int)(timer % 60);



        if (minutes == 0 && seconds == 0)
        {
            /*EndScreen.SetActive(true);
            EndScreen.GetComponent<Animation>().Play("EndScreen");
            AudioListener.volume = 0f;*/
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
