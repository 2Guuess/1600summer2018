using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DoAddition : ScriptableObject
{

    public int c;

    private void OnEnable()
    {
        c = Run(20, 2);
    }

    public int Run(int a, int b)
    {
        return a += b;
    }
}
