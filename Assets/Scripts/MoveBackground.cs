using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [Range(0, 3)]
    public float speed = 1; // Скорость прокрутки фона.
    private Animator animator;

    [Header("Camera")]
    public Camera cam;
    public float WidthCamera;
    public Vector2 centrCam; // Центр камеры.
    private float widthCam; // Половина ширины камеры.
    private float minX, maxX, minZ, maxZ;    
    private float sizePlaneX = 10; // Кф для растяжения по длинне Plane.

    private void Awake()
    {
        animator = GetComponent<Animator>();
        ScaleBackground();
        WidthCamera = widthCam * 2;
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

        transform.localScale = new Vector3((maxX - minX) / sizePlaneX, transform.localScale.y, transform.localScale.z); // Расчет размера камерыдля верстки фона.
    }
}
