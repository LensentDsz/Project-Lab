using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightRed : MonoBehaviour
{
    float count;
    public Renderer renderer;
    void start()
    {
        count = 0;
        renderer = gameObject.GetComponent<Renderer>();
    }
    void Update()
    {

        count = count + Time.deltaTime;
        if (count >8 && count <15)
        {
            renderer.material.color = Color.red;
        }
        else if (count <=8 )
            renderer.material.color = Color.black;
        else if (count > 15)
            count = 0;
    }
}
