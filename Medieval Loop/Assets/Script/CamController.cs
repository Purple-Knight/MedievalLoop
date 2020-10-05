using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CamController : MonoBehaviour
{
    
    public Vector3 mondePosition;
    public Vector3 bossPosition;

    public Transform camera;

    public bool boss;
    public bool bossSpeak = false;

    void Start()
    {
        camera.position = mondePosition;
    }

    // When space is pressed, cameraview changes from one room to the other
    void Update()
    {
        if(!boss)
        {
            transform.position = mondePosition;
        }
        else
        {
            transform.position = bossPosition;
        }
    }
    
}
