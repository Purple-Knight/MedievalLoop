using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Security.Cryptography;
using UnityEngine;

public class Cage : MonoBehaviour
{
    public float speed;
    public Transform destination;
    public Vector3 set;
    private bool fall = false;
    public GameObject cage;

    private void Awake()
    {
        cage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (fall == true)
        {
            Vector3 dir = destination.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);


            if (Vector3.Distance(transform.position, destination.position) < 1.3f)
            {
                cage.SetActive(true);
            }

            if (Vector3.Distance(transform.position, destination.position) <0.3f)
            {
                fall = false;
                cage.SetActive(false);
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            fall = true;
            //cage.SetActive(true);
        }
    }
}
