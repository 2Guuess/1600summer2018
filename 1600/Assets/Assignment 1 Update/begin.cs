using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class begin : ScriptableObject
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




	}

    public PowerUpBase PowerUp;

    public void UpdateHealth()
    {
        Health += 100;
    }
}
