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
}
