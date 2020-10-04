using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Scie : MonoBehaviour
{
    public float speed;

    public Transform[] wayPoints;
    private Transform target;

    private int desPoint = 0;

    //private DeadPlayer player;
    
    // Start is called before the first frame update
    void Start()
    {
        target = wayPoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        
        target = wayPoints[desPoint];
        
        if(Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            desPoint = (desPoint + 1) % wayPoints.Length;
            
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            col.transform.position = GameObject.FindGameObjectWithTag("Spawn").transform.position;
        }
    }
}
