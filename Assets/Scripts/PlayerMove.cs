using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
        // Normal Movements Variables
        [SerializeField] private Rigidbody2D player;
        private int curSpeed = 8;

        void Start()
        {
        }

        void FixedUpdate()
        {
            // Move sentences
            player.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f),
                Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));
        }
    
}
