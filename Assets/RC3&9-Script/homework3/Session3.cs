using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3 : MonoBehaviour
{
    public float Anglespeed;

    //1 每一帧让cube移动一下位置 Let the Cube move in each frame;

    void Update()
    {
        //1.Translate and Rotat

        gameObject.transform.Translate(new Vector3(0.02f, 0.005f, 0));
        transform.Rotate(Vector3.left, Time.deltaTime * Anglespeed);
        
        //2.GetKetDown and SwitchColor

        if (Input.GetKeyDown(KeyCode.R))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        float deltime = Time.deltaTime;
        //deltime += Time.deltaTime;
            //Debug.Log(deltime);

        //3.Change the Cube Color by time;

            if (deltime >= 0.29f) //a little strange?
            {
                Debug.Log("Switch color");
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }

        //if (deltime <= 20.0f)
        {
           

        }
    }
}
