using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSeek : MonoBehaviour
{
    public Seek seek;

    public GameObject[] possibleTargets;

    public float switchTime = 15f;

    private void Start()
    {
        StartCoroutine(SwitchTimer());
    }

    IEnumerator SwitchTimer()
    {
        yield return new WaitForSeconds(switchTime);
        SwitchTarget();
    }

    void SwitchTarget()
    {
        int randomIndex = Random.Range(0, possibleTargets.Length);

        GameObject newtarget = possibleTargets[randomIndex];

        seek.targetGameObject = newtarget;

        StartCoroutine(SwitchTimer());
    }
}
