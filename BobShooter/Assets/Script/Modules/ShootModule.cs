using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootModule : ScriptableObject
{
    public GameObject bullet;
    public GameObject egg;
    public Transform firePoint;
    public float speed;

    public ShootModule(GameObject bullet, Transform firePoint, float speed, GameObject egg)
    {
        this.bullet = bullet;
        this.firePoint = firePoint;
        this.speed = speed;
        this.egg = egg;
    }

    public void Egg(GameObject egg)
    {
        this.egg = egg;
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
