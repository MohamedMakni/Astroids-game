using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 1;
    public float a;
    public float b;
    public float c;
    public float d;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        Vector3 Movement = new Vector3(Random.Range(a,b), 0.0f, Random.Range(c, d));
        rb.AddForce(Movement);
    }


}