using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public int Hp = 1;

    private void Update()
    {
        DestroyGameObject();
    }

    private void DestroyGameObject()
    {
        if (Hp == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Hp -= 1;
        }
    }
}
