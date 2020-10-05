using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageGoToStart : MonoBehaviour
{
    public GameObject cage;
    public GameObject startPoint;
    private void OnTriggerEnter2D (Collider2D col)
    {
        if(col.tag == "Player")
        {
            cage.transform.position = GameObject.FindGameObjectWithTag("Start").transform.position; 
        }
    }
}
