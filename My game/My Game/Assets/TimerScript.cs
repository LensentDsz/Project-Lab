using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timertext;
    private float startTime;
    private float stopTime;
    bool isRunning;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }
    public void StartTimer()
    {
       if(!isRunning)
        {
            isRunning = true;
            startTime = t;
        }
    }
    public void Stop()
    {
        if (isRunning)
        {
            isRunning = false;
            stopTime = Time.time;
        }
    }
    public void Reset()
    {
        timertext.text = "00:00";
    }
    // Update is called once per frame
    void Update()
    {
        t = Time.time - startTime;
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f1");
        if(isRunning)
        {
            timertext.text = min + ":" + sec;
        }
       
    }
}
