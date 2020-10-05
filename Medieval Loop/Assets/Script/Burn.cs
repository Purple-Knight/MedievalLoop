using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : MonoBehaviour
{
    public AudioClip burn;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(burn, transform.position);
        }
    }
}
