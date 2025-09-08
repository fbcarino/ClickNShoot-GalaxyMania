using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptWin : MonoBehaviour
{
    public void nextMission()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastLevel") + 1);         //Go to the next level (next scene after the saved "lastLevel" in build settings)
    }
    public void missionSelect()
    {
        SceneManager.LoadScene("sceneLevelSelection");       //Go to Level Selection Page.
    }
    public void returnMainMenu()
    {
        SceneManager.LoadScene("sceneMainMenu");             //Go to Main Menu Page.
    }

}
