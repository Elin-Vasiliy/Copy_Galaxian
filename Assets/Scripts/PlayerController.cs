using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player")]
    public float horizontalSpeed;    
    private float speed;

    public GameObject shoot;
    private bool isShoot = false;

    [Header("Camera")]
    public Camera cam;
    private float minX, maxX;
    private Vector2 centrCam; // Центр камеры.
    private float widthCam; // Ширина камеры.

    private void Start()
    {
        ScaleCamera();
    }

    private void FixedUpdate()
    {
        isShoot = false;
        transform.Translate(speed, 0, 0);

        MoveToScreenBorder();
        isShootBool();
    }

    private void ScaleCamera()
    {
        widthCam = cam.orthographicSize * cam.aspect; // Получили половину ширины камеры.
        centrCam = cam.transform.position; // Получаем центр камеры, т.к. пивот в центре камеры.

        minX = centrCam.x - widthCam; // Левый край камеры.
        maxX -= minX; // Правый край камеры.
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

    public void ShootButton()
    {
        if(isShoot)
        {
            Vector3 position = transform.position;
            position.y += 0.3f;
            GameObject bullet = Instantiate(shoot, position, Quaternion.identity);
        }
    }

    private void isShootBool()
    {
        if (!GameObject.FindWithTag("Bullet"))
        {
            isShoot = true;
        }
    }
}
