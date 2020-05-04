using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehavior : MonoBehaviour
{
    public int score = 0;
    [SerializeField]
    private Text scoreText;

    private void Awake()
    {
        if (GameObject.Find("Score") != null &&
            GameObject.Find("Score") != gameObject)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
