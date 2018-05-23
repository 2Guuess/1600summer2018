using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorBehaviour : MonoBehaviour
{

    public ChangeUIColor changeUIColor;

	void Start ()
    {
        changeUIColor.ColorUI(GetComponent<Image>());	
	}

}
