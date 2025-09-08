using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptLose : MonoBehaviour
{
    public void tryAgain()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastLevel"));     //Return to scene that is currently remembered as the "lastLevel"
    }
    public void missionSelect()                                          
    {
        SceneManager.LoadScene("sceneLevelSelection");               //Go to Level Selection Page.
    }
    public void returnMainMenu()
    {
        SceneManager.LoadScene("sceneMainMenu");                     //Go to Main Menu Page.
    }

}
