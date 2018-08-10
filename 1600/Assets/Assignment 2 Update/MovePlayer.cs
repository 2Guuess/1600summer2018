using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 newPosition;

    public float Gravity = -9.81f;
    public float speed = 10f;
    public float jumpSpeed = 10.0f;
    public float maxHealth = 100;
    public float currentHealth;

    public GameObject GameOverPanel;

    public bool canRun = true;

	void Start ()
    {
        currentHealth = maxHealth;
        controller = GetComponent<CharacterController>();
	}

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ;

        newPosition.y = jumpSpeed;
        newPosition.y = Gravity;
        if(canRun)
        {
            newPosition.x = speed * Input.GetAxis("Horizontal");
        }
        controller.Move(newPosition * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        other.CompareTag("Enemy");
        {
            currentHealth--; 
            if(currentHealth <= 0)
            {
                GameOverPanel.SetActive(true);
                canRun = false;
            }
        }

        other.CompareTag("Health");
        {
            currentHealth++;
            currentHealth += maxHealth;
        }
    }
}
