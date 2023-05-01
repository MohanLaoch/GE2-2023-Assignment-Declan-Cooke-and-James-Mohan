using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harmonic : MonoBehaviour
{
    public float Speed = 1;
    public float rotAngleZ = 45;

    public GameObject Welkir;
    public GameObject PivotHolder1;
    public GameObject PivotHolder2;


    public Transform Arm1;
    public Transform Arm2;

    private void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        

        float rZ1 = Mathf.SmoothStep(0, -rotAngleZ, Mathf.PingPong(Time.time * Speed, 1));
        float rZ2 = Mathf.SmoothStep(0, rotAngleZ, Mathf.PingPong(Time.time * Speed, 1));

        Arm1.transform.position = PivotHolder1.transform.position;
        Arm2.transform.position = PivotHolder2.transform.position;

        Arm1.transform.rotation = Quaternion.Euler(0, 0, rZ1);
        Arm2.transform.rotation = Quaternion.Euler(0, 0, rZ2);

        

    }
}