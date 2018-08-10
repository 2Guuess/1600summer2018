using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public WeaponObject Weapon;
    public WeaponCollection collection;

    private void OnTriggerEnter(Collider other)
    {
        collection.CollectWeapon(Weapon);
    }

}
