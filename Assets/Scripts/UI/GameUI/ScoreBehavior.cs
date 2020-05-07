using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Updates the score text**/
public class ScoreBehavior : MonoBehaviour
{
    /**
     * Sets the score and the text that shows the score**/
    public int score = 0;
    [SerializeField]
    private Text scoreText;

    // Update is called once per frame
    void Update()
    {
        /**
         * Updates the score text**/
        scoreText.text = score.ToString();
    }
}
