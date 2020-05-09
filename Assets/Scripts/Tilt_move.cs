using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    [RequireComponent(typeof(Rigidbody2D))]
    public class Tilt_move : MonoBehaviour
    {
        float speed = 10F;
        Rigidbody2D rb2d;

        void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            Vector3 acc = Input.acceleration;
            rb2d.AddForceAtPosition(acc.x * speed, 0, acc.y * speed);
        }
    }

