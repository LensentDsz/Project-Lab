using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public int count = 0;
    public TimerScript timer;
   void Start()
    {
        count = 0;
    }
   void OnTriggerEnter(Collider collision)
    {
        if(collision.GetComponent<Collider>().tag == "Player")
        {
            count++;
            if (count % 2 != 0)
            {
                timer.StartTimer();
            }
            else
                timer.Stop();
        }
    }
}
