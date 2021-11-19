using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    static public BulletManager Instance;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;

    }

    public GameObject standerTurretPrefab;

    private void Start()
    {
        turretToBuild = standerTurretPrefab;
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

}
