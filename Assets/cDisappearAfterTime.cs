using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cDisappearAfterTime : MonoBehaviour
{
    public float timeToDisappear = 2;
    float timer = 0;


    private void Awake()
    {
        timer = 0;
    }
 

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToDisappear) gameObject.SetActive(false);
    }
}
