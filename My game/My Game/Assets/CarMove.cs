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
        //��ҿ��Ʋ���
        PlayerCtrl();
        //��������
        foreach (AxleInfo axleInfo in axleInfos)
        {
            //ת��
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            //����
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
               
            }
            //�ƶ�
            if (true)
            {
                axleInfo.leftWheel.brakeTorque = brakeTorque;
                axleInfo.rightWheel.brakeTorque = brakeTorque;
            }
        }
        
        
    }
    //��ҿ���
    void PlayerCtrl()
    {
        //������ת���
        motor = maxMotorTorque * -Input.GetAxis("Vertical");
        steering = maxSteeringAngle * Input.GetAxis("Horizontal");

    }
}


