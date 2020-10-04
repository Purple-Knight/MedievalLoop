using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    /*public float speed; 

        private Transform player; 
        private Vector2 target; 


        void Start() 
        { 
            player = GameObject.FindGameObjectWithTag("Player").transform; 

            target = new Vector2(player.position.x, player.position.y); 
        }*/

    void Update()
    {
        /*transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime); 
 
        if(transform.position.x == target.x && transform.position.y == target.y) 
        { 
            DestroyArrow(); 
        }*/
    }

    private void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.collider.gameObject.tag == "Player")
        {
            DestroyArrow();

        }
        else
        {
            DestroyArrow();
        }
    }

    void DestroyArrow()
    {
        Destroy(this.gameObject);
    }
}
