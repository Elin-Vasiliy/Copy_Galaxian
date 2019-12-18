using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private float speed = 5f; // Скорость пули.

    private void Start()
    {   
        BulletDestroy();
    }

    private void BulletDestroy() // Уничтожение пули
    {
        Destroy(gameObject, 1.5f); 
    }

    private void Update()
    {
        
        MoveBullet();
    }

    void MoveBullet() // Движение пули.
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
