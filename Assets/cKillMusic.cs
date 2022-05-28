using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cKillMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject musi = GameObject.FindGameObjectWithTag("music");
        Destroy(musi);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
