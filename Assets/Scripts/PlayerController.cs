using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player")]
    public float horizontalSpeed;    
    private float speed = 0.5f; // Скорость перемещения корабля.

    [Header("Plane")]
    public GameObject Plane;
    MoveBackground moveBackground;

    private void Start()
    {
        moveBackground = Plane.GetComponent<MoveBackground>();
    }

    public void RunMove()
    {
        transform.Translate(speed, 0, 0);

        MoveToScreenBorder();
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
        if(transform.position.x < moveBackground.minX)
        {
            transform.position = new Vector2(moveBackground.maxX, transform.position.y);
        }
        else if(transform.position.x > moveBackground.maxX)
        {
            transform.position = new Vector2(moveBackground.minX, transform.position.y);
        }
    }
}
