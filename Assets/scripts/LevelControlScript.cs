using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour
{
    public static LevelControlScript instance = null;
      
    int sceneIndex,levelPasssed;
    // Start is called before the first frame update
    void Start()
    {
          if(instance ==null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPasssed = PlayerPrefs.GetInt("LevelPassed");
    }

    public void youWin()
    {
        if(sceneIndex == 12)
            Invoke("loadMainMenu", 1f);
        else 
        {
            if (levelPasssed<sceneIndex)
                PlayerPrefs.SetInt("LevelPassed",sceneIndex);
            Invoke("loadNextLevel",1f);
        }
    }

    // Update is called once per frame
    void loadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
        Physics2D.gravity = new Vector2(0f,-9.81f);

    }

    void loadMainMenu()
    {
        SceneManager.LoadScene("CreditScene");
    }
       public void skip()
    {
         SceneManager.LoadScene("CreditScene");
    }
}
