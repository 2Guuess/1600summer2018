using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class begin : MonoBehaviour
{
    public float speed = 5f;
    public float Health;


	void Start ()
    {

	}

	void Update ()
    {

        transform.Rotate(speed, 0, 0);


	}
}
