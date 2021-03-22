using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public float speed = 5;

    List<ScriptableObject> Modules;
    public ShootModule shootComponent;

    void Start()
    {
        shootComponent = new ShootModule(bullet, firePoint, speed);

        Modules = new List<ScriptableObject>();
        Modules.Add(shootComponent);
        TAccessor<ShootModule>.Instance().Add(shootComponent);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            Instantiate(bullet, firePoint);
        }
    }
}
