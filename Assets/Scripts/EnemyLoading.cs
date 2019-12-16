using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLoading : MonoBehaviour
{
    public GameObject Enemy;

    MoveBackground moveBackground;

    private int[] pole;
    private int height = 10;
    private int width = 4;

    private void Start()
    {
        moveBackground = FindObjectOfType<MoveBackground>();
        
        LoadingEnemies();
    }

    private void LoadingEnemies()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Vector2 temp = new Vector2((moveBackground.centrCam.x - (moveBackground.WidthCamera / 2) + i * SizeBoxEnemies(moveBackground.WidthCamera)) + 1.0f, j + 1);
                GameObject newEnemy = Instantiate(Enemy, temp, Quaternion.identity);
            }
        }
    }

    private float SizeBoxEnemies(float width)
    {
        return width / 10;
    }
}
