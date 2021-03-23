using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGameManager : MonoBehaviour
{
    public GameManager gameManager;

    public void QuitGame()
    {
        gameManager.QuitGame();
    }

    public void PauseGame()
    {
        gameManager.PauseGame();
    }

    public void ReturnToMainMenu()
    {
        gameManager.ReturnToMainMenu();
    }

    public void InitializeGame()
    {
        gameManager.InitializeGame();
    }

}
