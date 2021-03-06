﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if(instance != null)
        {

        }
        instance = this;   
    }

    public GameObject standartTurretPrefab;
    public GameObject missleLauncherPrefab;

    private TurretBluePrint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn(Node node)
    {
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not Enough Money");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        Debug.Log("Turret build! Money left" + PlayerStats.Money);
    }

    public void SelectTurretToBuild(TurretBluePrint turret)
    {
        turretToBuild = turret;
    }
}
