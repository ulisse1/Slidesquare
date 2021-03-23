using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System;

public class GameManager : MonoBehaviour
{

    public float toggleGameOver = 1f;
    public float toggleHighScore = 2f;
    private bool gameHasEnded = false;
    private bool isPaused = false;
    public CameraFollow cameraFollow;
    public PlayerController controller;
    public CanvasScore canvasScore;
    public Text newHighscore;
    

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            //Toggling off every script
            gameHasEnded = true;
            cameraFollow.enabled = false;
            controller.enabled = false;
            canvasScore.enabled = false;
            Invoke("ToggleEndGameText", toggleGameOver);
            HighscoreData data = SaveSystem.LoadHighScore();
            if(data == null)
            {
                Invoke("ToggleHighScoreText", toggleHighScore);
                SaveSystem.SaveHighscore(canvasScore.displayScore.text);
            } else
            {
                ulong dataScore = Convert.ToUInt64(data.score);
                ulong currentScore = Convert.ToUInt64(canvasScore.displayScore.text);
                if(dataScore < currentScore)
                {
                    Invoke("ToggleHighScoreText", toggleHighScore);
                    SaveSystem.SaveHighscore(canvasScore.displayScore.text);
                }
            }

            StartCoroutine(WaitForKeyPress());
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void ToggleEndGameText()
    {
        GameObject[] list = GameObject.FindGameObjectsWithTag("HiddenUIElement");
        foreach(var x in list)
        {
            x.GetComponent<Text>().enabled = true;
        }
        
    }

    private void ToggleHighScoreText()
    {
        GameObject hs = GameObject.FindGameObjectWithTag("HighScoreElement");
        hs.GetComponent<Text>().enabled = true;

    }


    private IEnumerator WaitForKeyPress()
    {
        bool done = false;
        while (!done) // essentially a "while true", but with a bool to break out naturally
        {   
          
            if (Input.anyKeyDown)
            {
                done = true; // breaks the loop
            }

            yield return null; // wait until next frame, then continue execution from here (loop continues)
        }
        RestartGame();
        // now this function returns
    }
    public void InitializeGame()
    {
        //Initializes the next scene.
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        //Actually returns to the first indexed scene.
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        GameObject menu = GameObject.FindGameObjectWithTag("Menu");
        if (isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
            menu.GetComponent<Canvas>().enabled = true;
            canvasScore.enabled = false;
        }
        else if (isPaused == true)
        {
            Time.timeScale = 1;
            isPaused = false;
            menu.GetComponent<Canvas>().enabled = false;
            canvasScore.enabled = true;
        }
    }
}
