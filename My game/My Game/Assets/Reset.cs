using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reset : MonoBehaviour
{
    public TimerScript timer;
    void Start()
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = "Reset";
    }
    public void OnClick()
    {
        timer.Reset();
    }

}
