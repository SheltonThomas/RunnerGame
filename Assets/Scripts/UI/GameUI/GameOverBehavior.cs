using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Used for gameovers.**/
public class GameOverBehavior : MonoBehaviour
{
    /**
     * Exits the game.**/
    public void Exit()
    {
        Application.Quit();
    }

    /**
     * Restarts the game**/
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
