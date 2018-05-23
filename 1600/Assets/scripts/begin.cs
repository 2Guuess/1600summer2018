using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class begin : MonoBehaviour
{
    public float speed = 5f;
    public float Health;
    public float Strenght = 1.0f;
    public int legCount = 2;


	void Start ()
    {

	}

	void Update ()
    {

        transform.Rotate(speed, 0, 0);


	}

    public PowerUpBase PowerUp;

    public void UpdateHealth()
    {
        Health += 100;
    }
}
