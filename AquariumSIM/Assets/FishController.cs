using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FishController : MonoBehaviour
{
    private void Start()
    {
        GetComponent<StateMachine>().SetGlobalState(new PatrolState());
    }
    
}
