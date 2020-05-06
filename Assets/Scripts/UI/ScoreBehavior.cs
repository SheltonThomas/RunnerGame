using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehavior : MonoBehaviour
{
    public int score = 0;
    [SerializeField]
    private Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
