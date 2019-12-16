using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private float speed = 7f; // Скорость пули.

    private void Start()
    {
        BulletDestroy();
    }

    private void BulletDestroy() // Уничтожение пули
    {
        Destroy(gameObject, 1.4f); 
    }

    private void Update()
    {
        MoveBullet();
    }

    void MoveBullet() // Движение пули.
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
    }
}
