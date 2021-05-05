using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class CameraMove : MonoBehaviour
    {
    public GameObject Player;
    public GameObject cam;
    public float speed;
        private void Awake()
        {
        Player = GameObject.FindGameObjectWithTag("Player");
        cam = Player.transform.Find("Camera").gameObject;

    }

        private void FixedUpdate()
        {
        follow();
        }
    private void follow()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position,cam.transform.position,Time.deltaTime*speed);
        gameObject.transform.LookAt(Player.gameObject.transform.position);
    }
     
    }

