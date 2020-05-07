using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Used to control the main menu buttons**/
public class MenuButtonBehavior : MonoBehaviour
{
    /**
     * Loads the starting scene**/
    public void LoadScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    /**
     * Quits the game.**/
    public void QuitGame()
    {
        Application.Quit();
    }
}
