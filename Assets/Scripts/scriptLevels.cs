using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptLevels : MonoBehaviour
{
    public Font defaultFont;        //Set a public font.
    GUIStyle defaultStyle;          //Set the GUI style to "default Style".

    void Start()
    {
        //Font Preferences
        defaultStyle = new GUIStyle();
        defaultStyle.fontSize = 200;
        defaultStyle.font = defaultFont;
        defaultStyle.normal.textColor = Color.white;
    }
    public void playLevel1()
    {
        SceneManager.LoadScene("sceneLevel1");        //Go to Level 1.
    }

    public void playLevel2()
    {
        SceneManager.LoadScene("sceneLevel2");        //Go to Level 2.
    }

    public void playLevel3()
    {
        SceneManager.LoadScene("sceneLevel3");        //Go to Level 3.
    }

    public void returntoMainMenu()
    {
        SceneManager.LoadScene("sceneMainMenu");      //Go to Main Menu.
    }

    void OnGUI()
    {
        GUI.Label(new Rect(1000, 150, 500, 325), "MISSIONS", defaultStyle);        //Display a text which says "Missions"
    }

}
