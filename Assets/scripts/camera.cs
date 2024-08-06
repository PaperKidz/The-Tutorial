using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera: MonoBehaviour
{
    public GameObject characterPrefab;
    public GameObject MainCamera;
    public bool isCameraMoved = false;
    // Start is called before the first frame update
    void Update()
    {
        if(characterPrefab.transform.position.x < -9 &&!isCameraMoved)
        {   
            isCameraMoved = true;
            MainCamera.transform.position = new Vector3(-19,0,-10);
            characterPrefab.transform.position = new Vector3(-11,-4,0);
            
        }
        
    }   
}
