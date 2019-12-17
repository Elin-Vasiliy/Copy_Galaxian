using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosionPref;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col)
        {
            ExplosionLoading(this.transform.position);
        }
    }

    public void ExplosionLoading(Vector2 vect)
    {
        Destroy(Instantiate(explosionPref, vect, Quaternion.identity), 1f);
    }
}
