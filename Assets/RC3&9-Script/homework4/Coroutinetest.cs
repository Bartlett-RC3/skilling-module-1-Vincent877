using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinetest : MonoBehaviour
{
    // Variable
    public GameObject CubeMan;
    IEnumerator CreateCubeMan;
    
    void Start()
    {
        CreateCubeMan = CubeMantest();
        StartCoroutine(CreateCubeMan);


    }

    // Update is called once per frame
    void Update()
    {   
        
        Debug.Log(Time.time);
        if (Time.time > 0.6f) 
        {
            StopCoroutine(CreateCubeMan);
        }
        
    }
    IEnumerator CubeMantest() 
    {
        while (true)
        {
            Vector3 dropPosition = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-3.0f, 6.0f), Random.Range(-6.0f, 4.0f));
            Quaternion dropRotation = new Quaternion(Random.Range(0, 90), Random.Range(90, 180), Random.Range(45, 120), 1);
            GameObject CubeM =  Instantiate(CubeMan, dropPosition, dropRotation);
            


            yield return new WaitForSeconds(0.1f);
        }


    }

}
