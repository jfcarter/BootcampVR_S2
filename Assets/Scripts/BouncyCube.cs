using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyCube : MonoBehaviour
{
    // RigidBody is refrenced to a variable named rb
    public Rigidbody rb;
    // The strength of how strong the force is 2
    public int JumpPower = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Bounce() 
    {
        // adds a force based on a variable that pushes the object up multiplied by how stong we set it to
        rb.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
    }

    public bool IsOnGround()
    { 
        // Shoots a Ray down to check if it hits ground
        if (Physics.Raycast(transform.position, Vector3.down, 1.0f))
        {
            return true;
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if space is pressed and the object is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround())
        {
            Bounce();
        }
    }
}
