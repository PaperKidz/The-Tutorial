using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class timerscript : MonoBehaviour
{
    float currenttime= 0f;
    
    void Update()
    {   
        //*starts timer*//
        currenttime += 1* Time.deltaTime;
        print(currenttime);
        //*reset timer if player moves*// 
        if (Input.GetKeyDown(KeyCode.Space))
       {
           currenttime= 0f;
       }
       if (Input.GetKeyDown(KeyCode.LeftArrow))
       {
           currenttime= 0f;
       }
       if (Input.GetKeyDown(KeyCode.RightArrow))
       {
           currenttime= 0f;
       }
       //*load next level if time reach 2 min*//
       if(currenttime >= 30f)
       {
           SceneManager.LoadScene("Level10");
       }

    }
}
