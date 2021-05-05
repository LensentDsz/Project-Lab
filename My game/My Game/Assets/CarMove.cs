using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public List<AxleInfo> axleInfos; 
    private float motor = 0;
    public float maxMotorTorque;
    private float brakeTorque = 0;
    public float maxBrakeTorque = 100;
    private float steering = 0;
    public float maxSteeringAngle;
    public Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().centerOfMass = tf.localPosition;
        //玩家控制操作
        PlayerCtrl();
        //遍历车轴
        foreach (AxleInfo axleInfo in axleInfos)
        {
            //转向
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            //马力
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
               
            }
            //制动
            if (true)
            {
                axleInfo.leftWheel.brakeTorque = brakeTorque;
                axleInfo.rightWheel.brakeTorque = brakeTorque;
            }
        }
        
        
    }
    //玩家控制
    void PlayerCtrl()
    {
        //马力和转向角
        motor = maxMotorTorque * -Input.GetAxis("Vertical");
        steering = maxSteeringAngle * Input.GetAxis("Horizontal");

    }
}


