using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loop : MonoBehaviour
{
    public int nLoop = 0;
    private CamController cam;
    public GameObject[] boucle;
    public int nboucle = 1;

    public string monde;

    void Start()
    {
        cam = Camera.main.GetComponent<CamController>();
        boucle[0].SetActive(true);
    }

    void Update()
    {
        if (nLoop < boucle.Length)
        {
            if (nboucle == nLoop)
            {
                nboucle++;
                boucle[nLoop].SetActive(true);
                //boucle[nLoop - 1].SetActive(false);
            }
        }

    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            nLoop++;
            if (nLoop == boucle.Length)
            {
                SceneManager.LoadScene(monde);
            }
            else
            {
                col.transform.position = GameObject.FindGameObjectWithTag("Spawn").transform.position;
                cam.boss = false;
                cam.bossSpeak = false;
            }


        }
    }
}
