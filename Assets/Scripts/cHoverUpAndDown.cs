using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cHoverUpAndDown : MonoBehaviour
{
    public float hoverCycleTime = 3;
    public float hoverHeight = 0.5f;
    public float timeOffset;

    float timeSpent = 0;
    float oldY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSpent += Time.deltaTime;
        float newY =  Mathf.Sin(timeSpent * hoverCycleTime) * hoverHeight;
        

        transform.position += Vector3.up * (newY - oldY);

        oldY = newY;
    }
}
