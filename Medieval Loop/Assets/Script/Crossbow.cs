using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    public float range;
    public Transform target;
    bool detected = false;
    Vector2 direction;


    public GameObject bullet;
    public Transform firePoint;
    public float fireRate;
    float timeBtwShoot = 0;
    public float force;

    public AudioClip shoot;


    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        Vector2 targetPos = target.position;

        direction = targetPos - (Vector2)transform.position;

        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, direction, range);

        if (rayInfo)
        {
            if (rayInfo.collider.gameObject.tag == "Player")
            {
                if (detected == false)
                {
                    detected = true;
                }
            }

            else
            {
                if (detected == true)
                {
                    detected = false;
                }
            }
        }

        if (detected)
        {
            transform.up = direction;
            if (Time.time > timeBtwShoot)
            {
                timeBtwShoot = Time.time + 1 / fireRate;
                AudioSource.PlayClipAtPoint(shoot, transform.position);
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject ArrowIns = Instantiate(bullet, firePoint.position, firePoint.rotation);
        ArrowIns.GetComponent<Rigidbody2D>().AddForce(direction * force);
    }

    /*private float timeBtwShoots; 
    public float startTimeBtwShoot; 
    public float startShootingDistance; 
    public GameObject arrow; 
 
    public Transform player; 
    private Vector2 target; 
    public Rigidbody2D rb; 
 
 
 
    void Start() 
    { 
        timeBtwShoots = startTimeBtwShoot; 
        player = GameObject.FindGameObjectWithTag("Player").transform; 
        target = new Vector2(player.position.x, player.position.y); 
 
    } 
 
    void Update() 
    { 
        if (Vector2.Distance(transform.position, player.position) < startShootingDistance) 
        { 
            if (timeBtwShoots <= 0) 
            { 
                Instantiate(arrow, transform.position, Quaternion.identity); 
                timeBtwShoots = startTimeBtwShoot; 
            } 
            else 
            { 
                timeBtwShoots -= Time.deltaTime; 
            } 
        } 
    }*/
}
