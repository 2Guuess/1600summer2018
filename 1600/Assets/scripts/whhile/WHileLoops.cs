﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WHileLoops : MonoBehaviour
{
    public Text DisplayText;

    public int i = 3;

	void Start ()
    {
        StartCoroutine(Ticker());
	}

    IEnumerator Ticker()
    {
        while(i > 0)
        {
            DisplayText.text = i.ToString();

            yield return new WaitForSeconds(1);
            i--;
        }

        DisplayText.text = "Text";

        yield return new WaitForSeconds(2);

        DisplayText.text = "";
    }
}