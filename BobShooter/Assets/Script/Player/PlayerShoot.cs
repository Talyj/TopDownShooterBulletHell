using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject egg;
    public Transform firePoint;
    public float speed;

    List<ScriptableObject> Modules;
    public ShootModule shootComponent;

    void Start()
    {
        shootComponent = new ShootModule(bullet, firePoint, speed, egg);

        Modules = new List<ScriptableObject>();
        Modules.Add(shootComponent);
        TAccessor<ShootModule>.Instance().Add(shootComponent);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(egg, firePoint.position, firePoint.rotation);
        }
    }
}
