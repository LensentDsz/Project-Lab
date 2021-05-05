using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightYellow : MonoBehaviour
{
    float count;
    static int go;
    public Renderer renderer;
    void start()
    {
        count = 0;
        renderer = gameObject.GetComponent<Renderer>();
    }
    void Update()
    {

        count = count + Time.deltaTime;
        if (count > 6 && count < 9)
        {
            renderer.material.color = Color.yellow;
        }
        else if (count > 15)
            count = 0;
        else 
            renderer.material.color = Color.black;
      
    }
}
