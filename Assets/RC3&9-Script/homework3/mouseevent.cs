using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseevent : MonoBehaviour
{


    bool flag = true;
    void Start()
    {
        void OnMouseDown()
        {
            if (flag)
            {
                print("点击它了");
                gameObject.transform.Rotate(Vector3.up, Time.deltaTime * 0.5f);
            }
        }
    }
}
    

