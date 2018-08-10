using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTrigger : MonoBehaviour
{
    public floatData healthLevel;
    public floatData evilPower;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        healthLevel.Value -= evilPower.Value;
    }
}
