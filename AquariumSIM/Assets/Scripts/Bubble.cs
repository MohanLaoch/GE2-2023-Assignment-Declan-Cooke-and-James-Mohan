using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float rangeMin = 1.5f;
    public float rangeMax = 4.0f;

    private float speed;
    private float destroyTimer;

    private void Awake()
    {
        speed = Random.Range(rangeMin, rangeMax);
        destroyTimer = Random.Range(rangeMin, rangeMax);
        StartCoroutine(Destroy());
    }

    private void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(destroyTimer);
        Destroy(this.gameObject);
    }
}
