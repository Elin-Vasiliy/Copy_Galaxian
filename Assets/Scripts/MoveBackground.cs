using System.Collections;
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
    private float sizeCam; // Ширина камеры.
    private float sizePlaneX = 10; // Кф для растяжения по длинне Plane.
    private float sizePlaneZ = 20; // Кф для растяжения по высоте Plane.

    private void Start()
    {
        animator = GetComponent<Animator>();
        sizeCam = cam.orthographicSize * cam.aspect; // Получили половину ширины камеры.
        print(sizeCam);
        centrCam = cam.transform.position; // Получаем центр камеры, т.к. пивот в центре камеры.

        minX = centrCam.x - sizeCam; // Левый край камеры.
        maxX -= minX; // Правый край камеры.
        minZ = centrCam.y - sizeCam; // Нижний край камеры.
        maxZ -= minZ; // Верхний край камеры.

        transform.localScale = new Vector3((maxX - minX) / sizePlaneX, transform.localScale.y, (maxZ - minZ) / sizePlaneZ);

        //ScaleBackground();
    }

    private void Update()
    {
        animator.speed = speed;
    }

    private void ScaleBackground()
    {
        minX = centrCam.x - sizeCam; // Левый край камеры.
        maxX -= minX; // Правый край камеры.
        minZ = centrCam.y - sizeCam; // Нижний край камеры.
        maxZ -= minZ; // Верхний край камеры.

        transform.localScale = new Vector3((maxX - minX) / sizePlaneX, transform.localScale.y, (maxZ - minZ) / sizePlaneZ);
    }
}
