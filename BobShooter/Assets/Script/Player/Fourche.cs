using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fourche : MonoBehaviour
{
    public float speed = 15;
    public Transform cock;

    void Start() {
        cock = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        //transform.position += (cock.position - transform.position) * speed * Time.deltaTime;
        Destroy(gameObject, 5);
    }
}
