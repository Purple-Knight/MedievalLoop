using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossRoom : MonoBehaviour
{
    private CamController cam;
    public AudioClip final;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CamController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if (cam.boss)
            {
                cam.boss = false;
            }
            else
            {
                cam.boss = true;
                if(!cam.bossSpeak)
                {
                    AudioSource.PlayClipAtPoint(final, transform.position);
                    cam.bossSpeak = true;
                }
            }
        }
    }
}
