using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArryAndDestory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CubeS4;
    public int NumberOfCube = 5;
    public float SpacingOfCube = 2.0f;

    void Start()
    {
       
            for (int i = 0; i < NumberOfCube; i++)
            {

                Vector3 cubeCopy = new Vector3(5f, i * SpacingOfCube, 1f);
                GameObject NewCubeS4 = Instantiate(CubeS4, cubeCopy, Quaternion.identity);
            }

       
    }

    // Update is called once per frame
    void Update()
    {

        //使cube上下移动
         if (Input.GetKeyDown(KeyCode.W)) 
                {
                    this.gameObject.transform.Translate(Vector3.up * 0.2f);
                }
         if (Input.GetKeyDown(KeyCode.S)) 
                {
            this.gameObject.transform.Translate(Vector3.down * 0.4f);
        }

        //判断射线是否看到物品
        //1 获取生成射线的物品的位置

        Vector3 RayGeneratorPosition = this.gameObject.transform.position;

        //2 射线生成的方向

        Vector3 RayGeneratorDirection = this.gameObject.transform.TransformDirection(Vector3.left);

        //3 声明一个变量去储存射线碰撞到的物体

        RaycastHit objectsHitByRay;

        //
        if (Physics.Raycast(RayGeneratorPosition, RayGeneratorDirection, out objectsHitByRay)) 
        {
            Debug.Log("it is");
            Debug.Log(objectsHitByRay.transform.name);
            Debug.Log(objectsHitByRay.point);
            Destroy(objectsHitByRay.transform.gameObject);
        }




        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hitInfo = new RaycastHit();
        //    if (Physics.Raycast(ray, out hitInfo))
        //    {
        //        if (hitInfo.collider.tag == "LittleCubeMan ")
        //        {
        //            Debug.Log("LittleCubeMan");
        //            //target = hitInfo.point;
        //            //target.y = 0.5f;
        //            // = false;

        //        }



        //    }
        //}




    }
}
