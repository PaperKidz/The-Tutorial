using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwap : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
            Physics2D.gravity = new Vector2(-9.81f,0f);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            Physics2D.gravity = new Vector2(0f,-9.81f);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            Physics2D.gravity = new Vector2(0f,9.81f);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            Physics2D.gravity = new Vector2(9.81f,0f);
        }
    }
}
