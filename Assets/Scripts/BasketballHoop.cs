using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballHoop : MonoBehaviour
{
    // method called OnPointScored everytime basketball goes throug the hoop s should have debug log to know you scored a point
    // Start is called before the first frame update

    public float points;
    public AudioSource audio;
    void Start()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("BasketBall"))
        {
            OnPointScored();

            Debug.Log("OnTriggerEnter");
        }
    }

    public void OnPointScored()
    {
        Debug.Log("PointScored");
        points += 1;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
