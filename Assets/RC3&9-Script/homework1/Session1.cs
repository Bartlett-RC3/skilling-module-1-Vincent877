using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WHNHScript 
{
    public class homework1 
    {
        public string helloworld;
    }
    public class homework2 
    {
    
    }

}


public class Session1 : MonoBehaviour
{
    //Variables
    public float Float = 0.4f;
    public int Int = 3;
    public string String = "WHN";

    //Constructor
    public Session1( ) 
    { }
    
    
    void Start()
    {  
        //Arry 
        int[] arry = { 0, 1, 2, 3, 4 };
        int[] barry = new int[5];
        //List
        List<float> listF = new List<float>() { 1f, 2f, 3f };
        listF.Add(4f);
        
        //Print List
        foreach (float i in listF)
        {
            Debug.Log(i);
        }

        ArrayList T = new ArrayList() { 1, "你好",1.2f };
        #region
        foreach (int i in arry) 

        {
            if (i <= arry.Length)
            {
                print(i+"still in arry");
            }
            else 
            {
                print("out");
                
            }
        }
        #endregion

        // Dictionary

        Dictionary<int,string> dic= new Dictionary<int,string>();
        dic.Add(0, "I ");
        dic.Add(1, "am");
        dic.Add(2,"Batman");

        string Bruceis = dic[2];//访问字典
        Debug.Log("Bruce is:"+ Bruceis);
        //Debug.Log(dic.TryGetValue(1,));

    }

    // Update is called once per frame
    void Update()
    {   //1.2.3 declare int，float and string
        int i = 1;
        float f = 1.0f;
        string str = "hello,world";
        print(i);
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            Debug.Log("int is :"+ i+"float is :"+ f +"str is :" + str);
        }
    }
}
