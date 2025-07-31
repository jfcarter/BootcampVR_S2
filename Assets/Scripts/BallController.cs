using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float timer;

    public Rigidbody rb;
    public float timeToDestroy = 30;
    public float reboundForceMultiplier = 1.2f;

    public void DestroyBall()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToDestroy)
        {
            DestroyBall();
            timer = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name.Contains("Baseball Bat"))
        {
            Debug.Log("Hit baseball bat");
            if (collision.contactCount > 0)
            {
                ContactPoint contact = collision.GetContact(0);

                // Get the normal at the contact point
                Vector3 normal = contact.normal;

                // Reflect the current velocity off the normal
                Vector3 reflectedVelocity = Vector3.Reflect(rb.velocity, normal);

                // Optional: Apply a multiplier to simulate hitting it harder
                rb.velocity = reflectedVelocity * reboundForceMultiplier;

                Debug.DrawRay(contact.point, normal, Color.red, 1f);
                Debug.Log("Reflected off bat! New velocity: " + rb.velocity);
            }
        }
    }
}
