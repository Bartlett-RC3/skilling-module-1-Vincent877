using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classSwitchColor : MonoBehaviour
{   public void CS()
    {
        Debug.Log("p");
        gameObject.GetComponent<Renderer>().material.color = Color.yellow; 
    }
  
    public void Update()
    {
       //if (Input.GetKeyDown(KeyCode.Z))
        {
           
        }  
    }
}
