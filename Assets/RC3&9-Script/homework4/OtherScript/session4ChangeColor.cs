using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class session4ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject changeColortest;
    IEnumerator changeColoerCube;
    void Start()
    {
        //variable
        changeColoerCube = changeColor();
        StartCoroutine(changeColoerCube);
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Time.time);
        if (Time.time > 2) 
        {
            StopCoroutine(changeColoerCube);
        }

    }
        IEnumerator changeColor() 
        {
        while (true)
        {
            Vector3 changeColorPos = new Vector3(Random.Range(-3.0f, 5.0f), Random.Range(-3.0f, 5.0f), Random.Range(-3.0f, 5.0f));
            Quaternion changeColorRot = new Quaternion(Random.Range(0, 90), Random.Range(90, 180), Random.Range(90, 180), 1);
            //Color = new Color(Random.Range(-3.0f, 5.0f), Random.Range(-3.0f, 5.0f), Random.Range(-3.0f, 5.0f));

            GameObject changeColorCopy = Instantiate(changeColortest, changeColorPos, changeColorRot);
            changeColorCopy.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100));

            yield return (0.5f);
        }
        }
    }
