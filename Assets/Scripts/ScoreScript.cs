using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text txt;
    public float Score = 0;

    private void Update()
    {
        txt.text = Score.ToString();
    }
}
