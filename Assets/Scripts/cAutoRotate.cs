using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cAutoRotate : MonoBehaviour
{
    public Vector3 rotation;
    public float rotationTime = 9999999;
    public float timePassed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timePassed += Time.deltaTime;

        if (timePassed < rotationTime)
            transform.Rotate(rotation);
    }
}
