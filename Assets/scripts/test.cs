using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    
    public GameObject assetPrefab;
    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         if (Input.GetMouseButtonDown(0))
         {
            worldPosition = new Vector3(worldPosition.x, worldPosition.y, -1);
             GameObject asset = Instantiate(assetPrefab ,worldPosition ,Quaternion.identity);
         }
    }
}
