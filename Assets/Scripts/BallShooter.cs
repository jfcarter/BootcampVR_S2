using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    private float timer;
    
    public GameObject ballPrefab;
    public float launchForce = 10;
    public float timeBetweenShots = 5;

    public void ShootBall()
    {
        GameObject spawnBall = Instantiate(ballPrefab, transform.position, transform.rotation);
        Rigidbody rb = spawnBall.GetComponent<Rigidbody>(); 
        rb.velocity = transform.forward * launchForce;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeBetweenShots)
        {
            ShootBall();
            timer = 0f;
        }
    }
}
