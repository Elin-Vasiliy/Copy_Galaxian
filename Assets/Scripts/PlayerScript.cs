using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : CharacterScript
{
    PlayerController playerController;

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    protected override void Update()
    {
        playerController.RunMove();
    }

    
    protected override void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet" || col.gameObject.tag == "Enemy")
        {
            Hp -= 1;
        }
    }
}
