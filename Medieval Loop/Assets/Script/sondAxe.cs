using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sondAxe : MonoBehaviour
{
    public AudioSource axeMove;
    public AudioClip soundAxe;

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if (!axeMove.isPlaying)
            {
                axeMove.clip = soundAxe;
                axeMove.Play();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            axeMove.Stop();
        }
    }
}
