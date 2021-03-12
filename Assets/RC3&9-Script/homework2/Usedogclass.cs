using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using doggClass;//调用doggclass的namespace，可以获得所有code under this namespace

public class Usedogclass : MonoBehaviour


{
    public string newcolor;

    //Variables
    dogclass taotao, lele, xiaobai;//declare three name of dog


    void Start()
    {
        taotao = new dogclass("taotao.Wang", 20.5f, 3, "white");
        lele = new dogclass("lele.Zhao", 15.5f, 8, "black");
        xiaobai = new dogclass("xiaobai.Bai", 12.5f, 9, "yellow");
    }

    
    void Update()
    {
        Debug.Log(taotao.GetWight());
        //lele.Eating();
       

        xiaobai.setColorToDDog(newcolor);
    }
}
