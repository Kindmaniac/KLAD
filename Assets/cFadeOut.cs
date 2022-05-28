using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cFadeOut : MonoBehaviour
{
    float timer = 0;
    public float growSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.localScale += new Vector3(Time.deltaTime * growSpeed, Time.deltaTime * growSpeed, Time.deltaTime * growSpeed);
        growSpeed -= Time.deltaTime / 10;
        if (growSpeed < 0) growSpeed = 0;
        
    }
}
