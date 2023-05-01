using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public float secondsToWait;

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("La Mer");
        StartCoroutine(NextAudio());
    }

    IEnumerator NextAudio()
    {
        yield return new WaitForSeconds(secondsToWait);
        FindObjectOfType<AudioManager>().Play("Dive");
    }

}
