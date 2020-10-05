﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            col.transform.position = GameObject.FindGameObjectWithTag("Spawn").transform.position;
        }
    }
}