using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCast : MonoBehaviour
{   //Get the position of the Scence by get key down;点击鼠标获取场景位置
    //Let the character work to that position 让人物走到那个位置
    //This component attach on the Cube（gameobject）
    

    //varible
    public float speed;
    private bool isOver = true;//默认值为true
    Vector3 target;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(ray, out hitInfo)) 
            {
                if (hitInfo.collider.name == "Plane") {
                    target = hitInfo.point;
                    target.y = 0.5f;
                    isOver = false;
                
                }
            }
        
        }
        MoveTo(target);
    }
    private void MoveTo(Vector3 target) {

        //transform.position 现在的位置
        
        if (!isOver)
        {  
            Vector3 V1 = target - transform.position;//两个位置向量相减
            transform.position += V1.normalized * speed * Time.deltaTime;//把移动方向的值加上原来transform.position的值赋给transform.position

            if (Vector3.Distance(target, transform.position) <= 0.2f) 
            {
                isOver = true;
                transform.position = target;
            }
            Debug.Log("");
        }
        
        }

    }

