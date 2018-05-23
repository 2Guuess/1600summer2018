using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : ScriptableObject
{
    [Range(0, 10)] public float PowerLevel = 10.0f;

    public begin anyAnimal;

    private void OnEnable()
    {
        Debug.Log("Power Up");
    }

    public void RunPowerUp()
    {
        anyAnimal.Health += PowerLevel;
    }
}
