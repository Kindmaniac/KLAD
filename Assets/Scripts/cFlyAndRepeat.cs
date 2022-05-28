using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cFlyAndRepeat : MonoBehaviour
{
    public bool isFlying = true;
    
    public Vector3 flightSpeed;
    public float flightTime = 10;
    public float flightTimeSpent = 0;
    Rigidbody rb;
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.localPosition -  flightSpeed *flightTimeSpent;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFlying)
        {
            flightTimeSpent += Time.deltaTime;
            //transform.localPosition = startPosition + (flightTimeSpent * flightSpeed);
            rb.velocity = flightSpeed;

            if (flightTimeSpent > flightTime) 
            { 
                flightTimeSpent = 0;
                transform.position = startPosition;
            }
        }

    }
}
