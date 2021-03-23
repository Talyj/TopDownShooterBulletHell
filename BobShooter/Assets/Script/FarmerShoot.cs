using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerShoot : MonoBehaviour
{
    public GameObject fourche;
    //public GameObject player;
    public GameObject firePoint;
    public float speed;
    public float shootDelay = 3.0F;

    List<ScriptableObject> Modules;
    private ShootFarmerModule shootFarmerComponent;

    void Start()
    {
        shootFarmerComponent = new ShootFarmerModule(fourche, firePoint, speed);

        Modules = new List<ScriptableObject>();
        Modules.Add(shootFarmerComponent);
        TAccessor<ShootFarmerModule>.Instance().Add(shootFarmerComponent);
    }

    void Update() {
        shootDelay -= Time.deltaTime;
        if(shootDelay <= 0) {
            Instantiate(fourche, firePoint.transform.position, firePoint.transform.rotation);
            shootDelay = 3.0F;
        }
    }

}
 