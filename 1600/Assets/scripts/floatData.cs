﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class floatData : ScriptableObject
{
    [Range (0,1)]public float Value;
}
