using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLoading : MonoBehaviour
{
    public GameObject Enemy;

    MoveBackground moveBackground;

    private int[] pole;
    private int height = 4; // Количество врагов в высоту.
    private int width = 16; // Количество врагов в ширину.

    private void Start()
    {
        moveBackground = FindObjectOfType<MoveBackground>();
        
        LoadingEnemies();
    }

    private void LoadingEnemies()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {

                float ofset = moveBackground.centrCam.x - (moveBackground.WidthCamera / 2) + SizeBoxEnemies(moveBackground.WidthCamera); // Сдвиг от края относительно числа врагов в начале уровня.
                Vector2 temp = new Vector2(ofset + i * SizeBoxEnemies(moveBackground.WidthCamera), j + 1); // Точка координат врага с учетом сдвига и числа врагов.
                GameObject newEnemy = Instantiate(Enemy, temp, Quaternion.identity); // Создаем экземпляр врагов.
                newEnemy.transform.parent = this.gameObject.transform;
            }
        }
    }

    private float SizeBoxEnemies(float widthScreen) // Передаем ширину экрана и вычисляем шаг промежутка между врагами.
    {
        return widthScreen / (width + 1.0f);
    }
}
