using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        FindObjectOfType<AudioManager>().Play("click");
    }
    public void QuitGame()
    {
        Debug.Log("Successfully quitted the game!");
        FindObjectOfType<AudioManager>().Play("click");
        Application.Quit();    
    }
    public void Options()
    {
        SceneManager.LoadScene("OptionMenu");
        FindObjectOfType<AudioManager>().Play("click");
    }
    public void Levels()
    {
           FindObjectOfType<AudioManager>().Play("click");      
           SceneManager.LoadScene("LevelMenu");
    }
}
