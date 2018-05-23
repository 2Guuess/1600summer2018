using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehaviour : MonoBehaviour
{
    public begin animal;

    private void Start()
    {
        print(animal.Health);
    }
}
