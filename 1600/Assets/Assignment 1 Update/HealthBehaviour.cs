using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehaviour : MonoBehaviour
{
    public Image healthImage;
    public floatData healthLevel;
    public int currentHealth;

	void Start ()
    {
        healthImage = GetComponent<Image>(); 
	}
	
	void Update ()
    {
        healthImage.fillAmount = healthLevel.Value;
	}

    public void damage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    private void healing(int amount)
    {
        currentHealth += amount;
    }
}
