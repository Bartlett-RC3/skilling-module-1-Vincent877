using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RC9
{

    public class Session4 : MonoBehaviour
    {
        public GameObject Prefab;
        void Start()
        {

        }


        // Update is called once per frame
        void Update()
        {
            //GetKeyDown and generate different Scale and Color Prefab;
            if (Input.GetKeyDown(KeyCode.C))
            {
                Vector3 pos = new Vector3();
                pos.y = 0.5f;
                pos.x = Random.Range(-7f, 7f);
                pos.z = Random.Range(-7f, 7f);
                float angle = Random.Range(0f, 360f);
                GameObject Cubecopy = Instantiate(Prefab, pos, Quaternion.AngleAxis(angle, Vector3.up));
                Cubecopy.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 2.0f), Random.Range(0f, 10.0f), Random.Range(2.0f, 15.0f));
                Cubecopy.transform.localScale = new Vector3(Random.Range(0f, 2f), Random.Range(0f, 3f), Random.Range(0f, 1.5f));

            }


        }
    }
}

