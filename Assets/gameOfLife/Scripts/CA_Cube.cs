using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CA_Cube : MonoBehaviour {

    // Variables
    private int state = 0;
    private int futureState = 0;
    public Color Color1;
    public Color Color2;

    // Update is called once per frame
    void Update()
    {
        state = futureState;
        DisplayCube();
    }

    // Display the cube
    void DisplayCube()
    {
        MaterialPropertyBlock props = new MaterialPropertyBlock();
        MeshRenderer renderer;
        if (state == 0)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        if (state == 1)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            StartCoroutine(ColorChange());
            renderer = gameObject.GetComponent<MeshRenderer>();
            renderer.SetPropertyBlock(props);

        }
    }
    public IEnumerator ColorChange()
    {
        Debug.Log("Genrating");
        float TimeStart = 0.0f;
        float TimeUse = 3.5f;
        while (TimeStart < TimeUse)
        {
            TimeStart += Time.deltaTime;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.Lerp(Color1, Color2, (TimeStart / TimeUse));
            yield return null;
        }
    }


    public void SetFutureState(int _futureState)
    {
        futureState = _futureState;
    }

    public void SetState(int _state)
    {
        futureState = _state;
    }

    public int GetState()
    {
        return state;
    }

    public int GetFutureState()
    {
        return state;
    }
}
