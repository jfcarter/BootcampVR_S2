using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSxript : MonoBehaviour
{
    public void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    public void OnEnable()
    {
        Debug.Log("Enable");
    }

    private void OnDisable()
    {
        Debug.Log("Disable");
    }

    private void OnDestroy()
    {
        Debug.Log("Destroyed");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TriggerExit");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CollisionEnter");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("CollisionExit");
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
