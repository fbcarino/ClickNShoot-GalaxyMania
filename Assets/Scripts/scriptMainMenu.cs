using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMainMenu : MonoBehaviour
{
    public Font defaultFont;         //Set a public font.
    GUIStyle defaultStyle;           //Set the GUI style to "default Style".

    // Start is called before the first frame update
    void Start()
    {
        //Font Style Settings
        defaultStyle = new GUIStyle();
        defaultStyle.fontSize = 300;
        defaultStyle.font = defaultFont;
        defaultStyle.normal.textColor = Color.white;
    }

    public void startGame()          
    {
        SceneManager.LoadScene("sceneLevel1");    //Go to Level 1.
    }

    public void levelSelect()
    {
        SceneManager.LoadScene("sceneLevelSelection");    //Go to Level Selection Page.
    }

    public void exitGame()      
    {
        print("Quitting game...");                  //Send a message that you are exitting the game.   
        Application.Quit();                         //Quit Game.
    }
    void OnGUI()
    {
        GUI.Label(new Rect(260, 350, 500, 325), "GALAXY MANIA", defaultStyle);    //Display a text which says "Galaxy Mania"
    }
    
}
