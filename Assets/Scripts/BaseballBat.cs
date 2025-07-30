using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseballBat : MonoBehaviour
{
    //TODO:
    //1: Make bat know when a baseball hits it
    //2: Make bat play a sound on hit
    //3: Find bat sound

    // Start is called before the first frame update
    public float baseballPoints;
    public AudioSource audio;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Baseball"))
        {
            OnBallHit();
        }
    }

    public void OnBallHit()
    {
        Debug.Log("BallHit");
        baseballPoints += 1;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
