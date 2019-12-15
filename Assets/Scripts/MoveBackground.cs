﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [Range(0, 3)]
    public float speed = 1;
    private Animator animator;

    [Header("Camera")]
    public Camera cam;
    private float minX, maxX, minZ, maxZ;
    private Vector2 centrCam; // Центр камеры.
    private float widthCam; // Ширина камеры.
    private float sizePlaneX = 10; // Кф для растяжения по длинне Plane.

    private void Start()
    {
        animator = GetComponent<Animator>();
        ScaleBackground();
    }

    private void Update()
    {
        animator.speed = speed;
    }

    private void ScaleBackground()
    {

        widthCam = cam.orthographicSize * cam.aspect; // Получили половину ширины камеры.
        centrCam = cam.transform.position; // Получаем центр камеры, т.к. пивот в центре камеры.

        minX = centrCam.x - widthCam; // Левый край камеры.
        maxX -= minX; // Правый край камеры.

        transform.localScale = new Vector3((maxX - minX) / sizePlaneX, transform.localScale.y, transform.localScale.z);
    }
}