using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harmonic : MonoBehaviour
{
    public float Speed = 1;
    public float rotAngleX = 45;



    public Transform Wing1;
    public Transform Wing2;

    private void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float rX1 = Mathf.SmoothStep(0, rotAngleX, Mathf.PingPong(Time.time * Speed, 1));
        float rX2 = Mathf.SmoothStep(0, -rotAngleX, Mathf.PingPong(Time.time * Speed, 1));



        Wing1.transform.rotation = Quaternion.Euler(rX1, 0, 0);
        Wing2.transform.rotation = Quaternion.Euler(rX2, 0, 0);

    }
}