using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class SunMove : MonoBehaviour

{

    public float speed = 0.1f;

    private int degree;



    void Start()

    {

        degree = 0;



        gameObject.transform.Rotate(degree, 0, 0);

    }



    void Update()

    {

        gameObject.transform.Rotate(-speed * Time.deltaTime, 0, 0);

    }

}