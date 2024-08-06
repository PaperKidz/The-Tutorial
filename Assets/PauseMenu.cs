using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   public static  bool GameIsPaused = false;

   public GameObject pauseMenuUI ;
   public GameObject canvasMenuUI ;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                {
                    Pause();
                }
            }
        }
        
    }
    public void Resume()
    {
        FindObjectOfType<AudioManager>().Play("click");
        pauseMenuUI.SetActive(false);
        canvasMenuUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false ;

    }

    void Pause()
    {
        FindObjectOfType<AudioManager>().Play("click");
        pauseMenuUI.SetActive(true);
        canvasMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void loadMenu()
    {
        FindObjectOfType<AudioManager>().Play("click");
        SceneManager.LoadScene(0);

    }
    public void quit()
    {
        FindObjectOfType<AudioManager>().Play("click");
        Debug.Log("Successfully Quitted");
        Application.Quit();
    }
}
