﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 5;

    public static int Lives;
    public int startLives = 2;

    void Start()
    {
        Money = startMoney;
        Lives = startLives;
    }
}
