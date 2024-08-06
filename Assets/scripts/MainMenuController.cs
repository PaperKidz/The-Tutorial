using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    public Button level02Button, level03Button,level04Button, level05Button,level06Button,level07Button, level08Button,level09Button,level10Button;
    int levelPassed;
    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level02Button.interactable= false;
        level03Button.interactable = false;
        level04Button.interactable= false;
        level05Button.interactable = false;
        level06Button.interactable= false;
        level07Button.interactable= false;
        level08Button.interactable = false;
        level09Button.interactable= false;
        level10Button.interactable= false;
        

        switch(levelPassed){
        case 1:
            level02Button.interactable = true;
            break;
        case 2:
            level02Button.interactable = true;
            level03Button.interactable = true;
            break;
        case 3:
            level02Button.interactable = true;
            level03Button.interactable = true;
            level04Button.interactable = true;
            break;
        case 4:
            level02Button.interactable = true;
            level03Button.interactable = true;
            level04Button.interactable = true;
            level05Button.interactable = true;
            break;
        case 5:
            level02Button.interactable = true;
            level03Button.interactable = true;
            level04Button.interactable = true;
            level05Button.interactable = true;
            level06Button.interactable = true;
            break;
        case 6:
            level02Button.interactable = true;
            level03Button.interactable = true;
            level04Button.interactable = true;
            level05Button.interactable = true;
            level06Button.interactable = true;
            level07Button.interactable = true;
            break;
        case 7:
            level02Button.interactable = true;
            level03Button.interactable = true;
            level04Button.interactable = true;
            level05Button.interactable = true;
            level06Button.interactable = true;
            level07Button.interactable = true;
            level08Button.interactable = true;
            break;
        case 8:
            level02Button.interactable = true;
            level03Button.interactable = true;
            level04Button.interactable = true;
            level05Button.interactable = true;
            level06Button.interactable = true;
            level07Button.interactable = true;
            level08Button.interactable = true;
            level09Button.interactable = true;
            break;
        case 9:
            level02Button.interactable = true;
            level03Button.interactable = true;
            level04Button.interactable = true;
            level05Button.interactable = true;
            level06Button.interactable = true;
            level07Button.interactable = true;
            level08Button.interactable = true;
            level09Button.interactable = true;
            level10Button.interactable = true;
            break;



        }
    }

   public void levelTOLoad(int level)
   {
       FindObjectOfType<AudioManager>().Play("click");
       SceneManager.LoadScene(level);
   }
   public void resetPlayerPrefs()
   {
       level02Button.interactable = false;
       level03Button.interactable = false;
       level04Button.interactable = false;
       level05Button.interactable = false;
       level06Button.interactable = false;
       level07Button.interactable = false;
       level08Button.interactable = false;
       level09Button.interactable = false;
       level10Button.interactable = false;
       
       PlayerPrefs.DeleteAll();
   }
   public void BackButton()
   {
       FindObjectOfType<AudioManager>().Play("click");
       SceneManager.LoadScene(0);
   }
}
