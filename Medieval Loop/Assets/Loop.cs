using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public int nLoop = 0;
    private CamController cam;
    public GameObject[] boucle;
    public int nboucle = 1;

    void Start()
    {
        cam = Camera.main.GetComponent<CamController>();
        boucle[0].SetActive(true);
    }

    void Update()
    {
        if (nboucle == nLoop)
        {
            nboucle++;
            boucle[nLoop].SetActive(true);
            boucle[nLoop - 1].SetActive(false);
        }

    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            col.transform.position = GameObject.FindGameObjectWithTag("Spawn").transform.position;
            nLoop++;
            cam.boss = false;
        }
    }
}
