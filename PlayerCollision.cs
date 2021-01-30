using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{   
    void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag == "GameOver")
        {
            FindObjectOfType<AudioManager>().Play("GameOver");
            GameOver.level = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene("GameOver");
        }

        if (collision.gameObject.tag == "NextLevel")
        {
            if(Congratulations.completed == false){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

            if(Congratulations.completed == true){
                SceneManager.LoadScene("Level");
            }
        }
    }
}