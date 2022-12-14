using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public Transform top;
    public Transform botton;
    
    public float speed = 5f;

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x-1f;
    }

    private void Update()
    {
        transform.position += Vector3.left  *speed * Time.deltaTime;

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
