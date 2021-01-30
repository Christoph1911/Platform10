using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    public void PlayGame(){
        SceneManager.LoadScene(GameOver.level);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void HTP(){
        SceneManager.LoadScene("HTP");
    }

    public void LevelSelection(){
        if(Congratulations.completed == true){
            SceneManager.LoadScene("Level");
        }
    }

    public void About(){
        SceneManager.LoadScene("About");
    }

}
