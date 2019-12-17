using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public int Hp = 1;
    public bool isOk;

    private void Update()
    {
        DestroyGameObject();
        isOk = false;
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

    //public virtual void OnTriggerEnter2D(Collider2D collider)
    //{
    //    if (collider == GameObject.FindWithTag("Bullet"))
    //    {
    //        Hp -= 1;
    //    }
    //    isOk = true;
    //}

}
