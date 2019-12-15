using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public int Hp = 1;

    public virtual void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider)
        {
            Hp -= 1;
        }
    }

}
