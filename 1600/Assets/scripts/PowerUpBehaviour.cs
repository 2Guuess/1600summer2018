using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehaviour : MonoBehaviour
{
    public PowerUpBase powerUp;

    private void OnMouseDown()
    {
        Debug.Log(powerUp.PowerLevel);
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        powerUp.RunPowerUp();
    }
}
