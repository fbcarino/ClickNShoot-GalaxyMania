using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptGameComplete : MonoBehaviour
{
    public void returnMainMenu()
    {
        SceneManager.LoadScene("sceneMainMenu");                 //Go to Main Menu Page.
    }

    public void exitGame()
    {
        print("Quitting game...");        //Send a message that you are exitting the game.                   
        Application.Quit();               //Quit Game.
    }
}
