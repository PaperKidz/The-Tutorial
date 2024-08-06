using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("spikes"))
        {
            LevelManager.instance.Respawn();
            Destroy(gameObject);    
        }

        if(collision.gameObject.CompareTag("marioblock"))
        {
            
            Destroy(collision.gameObject);
        }

        

        
    }
}
