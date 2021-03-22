using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attaque : MonoBehaviour
{
    public float speed = 5;
    public GameObject egg;
    public Transform firePoint;

    public bool isFiring = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        Destroy(gameObject, 3);

        Instantiate(egg, firePoint);
    }
}
