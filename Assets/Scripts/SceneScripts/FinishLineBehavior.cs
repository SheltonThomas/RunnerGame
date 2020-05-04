using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineBehavior : MonoBehaviour
{
    public int nextSceneId;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nextSceneId);
        }
    }
}
