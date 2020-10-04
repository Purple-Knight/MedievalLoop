using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NLoop : MonoBehaviour
{

    public GameObject[] boucle;

    private Loop loop;
    public int nboucle = 1;

    void start()
    {
        boucle[0].SetActive(true);
    }
        
    void Update()
    {
        if(nboucle == loop.nLoop)
        {
            nboucle++;
            boucle[loop.nLoop].SetActive(true);
            if(loop.nLoop!=0)
            {
                boucle[loop.nLoop-1].SetActive(false);
            }
            
        }

    }
}
