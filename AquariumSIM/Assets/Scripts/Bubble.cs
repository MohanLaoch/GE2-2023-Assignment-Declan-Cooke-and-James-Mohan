using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float rangeMin = 1.5f;
    public float rangeMax = 4.0f;

    private float speed;
    private float destroyTimer;
    private float size;

    private void Awake()
    {

        speed = Random.Range(rangeMin, rangeMax);
        destroyTimer = Random.Range(rangeMin, rangeMax);
        size = Random.Range(rangeMin / 2, rangeMax / 2);

        transform.localScale = new Vector3(size, size, size);

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
