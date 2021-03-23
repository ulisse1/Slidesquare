using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadHighscore : MonoBehaviour
{
    public Text hsText;

    // Start is called before the first frame update
    void Start()
    {
        HighscoreData data = SaveSystem.LoadHighScore();
        hsText.text += data.score;
    }
}
