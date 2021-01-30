using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static int level = 5;

    public void TryAgain(){
        SceneManager.LoadScene(level);
    }

    public void Back(){
        SceneManager.LoadScene("Menu");
    }

    public void I(){
        SceneManager.LoadScene("Level 1");
    }

    public void II(){
        SceneManager.LoadScene("Level 2");
    }

    public void III(){
        SceneManager.LoadScene("Level 3");
    }
}
