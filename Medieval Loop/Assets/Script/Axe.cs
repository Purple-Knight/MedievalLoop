using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{

    public Vector3 rotationSpeed;
    public AudioClip axe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(axe, transform.position);
            col.transform.position = GameObject.FindGameObjectWithTag("Spawn").transform.position;
        }
    }
}
