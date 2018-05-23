using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehaviour : MonoBehaviour
{
    public Image healthImage;
    public floatData healthLevel;

	void Start ()
    {
        healthImage = GetComponent<Image>(); 
	}
	
	void Update ()
    {
        healthImage.fillAmount = healthLevel.Value;
	}
}
