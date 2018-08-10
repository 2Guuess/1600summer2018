using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    private Rigidbody rb;

    public floatData speed;
    public floatData upGrade;

	private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, speed.Value);
        Invoke("DestroyObject", 2);
	}

    private void DestroyObject()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = upGrade;
        rb.AddForce(0, 0, speed.Value);
    }
}