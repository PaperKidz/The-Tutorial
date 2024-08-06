using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public Transform respawnPoint;
    public GameObject characterPrefab;

    private void Awake()
    {
        instance = this;
    
    }

    public void Respawn()
    {
        GameObject character = Instantiate(characterPrefab , respawnPoint.position,Quaternion.identity);
    }
   

    public void Level3()
    {   
           SceneManager.LoadScene("level3");
    }
}
