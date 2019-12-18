using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterScript : MonoBehaviour
{
    [SerializeField] protected float Hp = 1f;
    [SerializeField] protected float SpeedMove = 1f;
    [SerializeField] protected float Points = 1f;
    ScoreScript scoreScript;

    private void Awake()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
    }

    protected virtual void Update()
    {
        DestroyGameObject();
    }

    protected virtual void DestroyGameObject()
    {
        if (Hp == 0)
        {
            scoreScript.Score += Points;
            gameObject.SetActive(false);            
        }
    }

    protected virtual void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Hp -= 1;
        }
    }
}
