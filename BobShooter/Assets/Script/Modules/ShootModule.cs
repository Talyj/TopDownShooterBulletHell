using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootModule : ScriptableObject
{
    public GameObject bullet;
    public Transform firePoint;
    public float speed = 5;

    public ShootModule(GameObject bullet, Transform firePoint, float speed)
    {
        this.bullet = bullet;
        this.firePoint = firePoint;
        this.speed = speed;
    }

    public void Speed( float speed)
    {
        this.speed = speed;
    }
    public void Bullet(GameObject bullet)
    {
        this.bullet = bullet;
    }

    public void FirePoint(Transform firePoint)
    {
        this.firePoint = firePoint;
    }


}
