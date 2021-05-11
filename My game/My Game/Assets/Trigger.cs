using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    
    public TimerScript timer;
   void Start()
    {
       
    }
   void OnTriggerEnter(Collider collision)
    {
        if(collision.GetComponent<Collider>().tag == "Player")
        {
            timer.count++;
            if (timer.count % 2 != 0)
            {
                timer.StartTimer();
            }
            else
                timer.Stop();
        }
    }
}
