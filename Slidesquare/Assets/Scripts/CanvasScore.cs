using UnityEngine;
using UnityEngine.UI;

public class CanvasScore : MonoBehaviour
{
    public Transform player;
    public Text displayScore;
    public float scoreMultiplier = 0f;
    // Update is called once per frame
    void Update()
    {
        displayScore.text = (scoreMultiplier).ToString("0");
        scoreMultiplier += 0.2f;
    }
}
