﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private float speed = 5f;

    private void Start()
    {
        Destroy(gameObject, 5.4f);
    }

    private void Update()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
    }
}