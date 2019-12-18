using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaeyrShooting : MonoBehaviour
{
    public GameObject Bullet;

    public void ShootButton()
    {
        Shooting();
    }

    private void Shooting()
    {
        if(!GameObject.FindGameObjectWithTag("Bullet"))
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
            GameObject bullet = Instantiate(Bullet, position, Quaternion.identity);
        }
    }
}
