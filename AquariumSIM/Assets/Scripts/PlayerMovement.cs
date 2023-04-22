using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController playerControls;

    public float speed;

    private void Awake()
    {
        playerControls = new PlayerController();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void Update()
    {
        float x = playerControls.Movement.XAxis.ReadValue<float>();

        float y = playerControls.Movement.YAxis.ReadValue<float>();

        float z = playerControls.Movement.ZAxis.ReadValue<float>();

        transform.Translate(speed * x * Time.deltaTime, 0, 0);

        transform.Translate(0, speed * y * Time.deltaTime, 0);

        transform.Translate(0, 0, speed * z * Time.deltaTime);
    }
}
