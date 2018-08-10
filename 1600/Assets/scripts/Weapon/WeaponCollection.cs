using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponsCollection", menuName = "Artisan Dream")]
public class WeaponCollection : ScriptableObject
{
    public List<WeaponObject> Weapons;

    public void CollectWeapon(WeaponObject weapon)
    {
        Weapons.Add(weapon);

        foreach(var item in Weapons)
        {
            Debug.Log(item);
            if(item.name == "sword")
            {
                Debug.Log("You got sword");
            }
        }
    }
}
