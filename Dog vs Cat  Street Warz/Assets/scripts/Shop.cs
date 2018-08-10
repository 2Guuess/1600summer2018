using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBluePrint standartTurret;
    public TurretBluePrint missleLauncher;

    BuildManager buildManager;

	void Start ()
    {
        buildManager = BuildManager.instance;	
	}

    public void SelectTurret()
    {
        buildManager.SelectTurretToBuild(standartTurret);
    }

    public void SelectMissleLauncher()
    {
        buildManager.SelectTurretToBuild(missleLauncher);
    }

}
