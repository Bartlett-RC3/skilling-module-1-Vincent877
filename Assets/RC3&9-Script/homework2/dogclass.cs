
//library
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//namespace--如同一个图书馆
namespace doggClass
{
    //CLASS----图书馆里的一本书
    public class dogclass //第一个class
    {
        //VARIABLE
        string name;
        float weight;
        int age;
        string color;

        //CONSTRUCTOR --- 储存和调用之前声明的构造函数
        //                构造函数的名和类型名完全一样
        public dogclass(string _name, float _weight,int _age,string _color)//把变量传递到构造函数里
        {
            name = _name;
            weight = _weight;
            age = _age;
            color = _color;
            setColorToDDog(color);//color是展位符吗，调用一下看看
            //传参后把参数实例化
            //下划线增强可读性
        }

        //BEHAVIORS(Functions)
        public string GetName() //创建方法--设置成void就不需要return了
        {
            return name;
        }//访问constructor里的变量
        public float GetWight() 
        {
            return weight;
        }
        public void SetAge(int _age) 
        {
            age = _age;
        }
        //Functions others get or set value for a class

        private void Sleep() 
        {
           //go to bed
        }
        public void Walking() 
        {
            
            //Debug.Log("I am hunding");
        }
        public void Eating() 
        {
            Debug.Log("I am eating bone");
        }

        public void setColorToDDog(string _color) 
        {
            color = _color;
            Debug.Log("Set the color do you want");
 
            Debug.Log(name + " is :" + color);
        }

        


    }





    class CyborDog 
    {
        // Variable 

        //string name;
       // float weight;
        string master;

        // Constructor -- first thing
        public CyborDog(string _name, float _weight, string _master)
        {
           
            master = _master;

        }

        // Behavior 

        public void Scan()
        {
            Debug.Log("scan the environment");

        }
        public void Security()
        {
            Debug.Log("protect" + master);
        }
    }

}
