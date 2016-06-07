﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * speed);
        }
    }
}