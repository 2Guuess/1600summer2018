using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HealthPowerUp : PowerUpBase
{
    public float Health = 100;

    public GameObject checkpoint;

    void OnMouseDown()
    {
        Health += 100;
        if(Health <=0)
        {
            Destroy(checkpoint);
        }
    }

}
