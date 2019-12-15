using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player")]
    public float horizontalSpeed;    
    private float speed;

    Shoot shoot;

    [Header("Camera")]
    public Camera cam;
    private float minX, maxX;
    private Vector2 centrCam; // Центр камеры.
    private float widthCam; // Ширина камеры.

    private void Start()
    {
        ScaleCamera();
        shoot = GetComponent<Shoot>();
    }

    private void FixedUpdate()
    {
        transform.Translate(speed, 0, 0);

        MoveToScreenBorder();
    }

    private void ScaleCamera()
    {
        widthCam = cam.orthographicSize * cam.aspect; // Получили половину ширины камеры.
        centrCam = cam.transform.position; // Получаем центр камеры, т.к. пивот в центре камеры.

        minX = centrCam.x - widthCam; // Левый край камеры.
        maxX = centrCam.x + widthCam; // Правый край камеры.
    }

    public void LeftButtonMove()
    {
        speed = -horizontalSpeed;
    }

    public void RightButtonMove()
    {
        speed = horizontalSpeed;
    }

    public void StopMove()
    {
        speed = 0;
    }

    private void MoveToScreenBorder()
    {
        if(transform.position.x < minX)
        {
            transform.position = new Vector2(maxX, transform.position.y);
        }
        else if(transform.position.x > maxX)
        {
            transform.position = new Vector2(minX, transform.position.y);
        }
    }

    private void ShootButton()
    {
        if(!GameObject.FindWithTag("Shoot"))
        {
            Instantiate(shoot);
        }
    }
}
