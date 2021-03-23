using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFarmerModule : ScriptableObject
{
    public GameObject fourche;
    public GameObject firePoint;
    public float speed;

    public ShootFarmerModule(GameObject fourche, GameObject firePoint, float speed)
    {
        this.fourche = fourche;
        this.firePoint = firePoint;
        this.speed = speed;
    }

    public void Speed( float speed)
    {
        this.speed = speed;
    }

    public void Fourche(GameObject fourche)
    {
        this.fourche = fourche;
    }

    public void FirePoint(GameObject firePoint)
    {
        this.firePoint = firePoint;
    }

}
