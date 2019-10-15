using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMover : MonoBehaviour
{
   
        public Rigidbody rb;
         public float speed = 1;
         void Start()
         {
             rb = GetComponent<Rigidbody>();

         }

        void Update()
        {
        Vector3 Movement = new Vector3(Random.Range(-1, 1),0.0f, Random.Range(-1, 1));
        rb.AddForce(Movement);
    }


    }
