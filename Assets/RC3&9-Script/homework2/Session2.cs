using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { //1声明一个arry
      //2 条件1：当按下mouse的
      //3 for条件如果：i小于arry的长度就打印，否则跳出循环

        
    }

    // Update is called once per frame
    void Update()
    {
        
        int[] array = new int[5];
        if (Input.GetMouseButtonDown(0))
        {
            print("按下鼠标左键");
            for (int i =0; i<= array.Length; i++) 
            {
                print(i + "在这里");

            }
        }
    }
}
