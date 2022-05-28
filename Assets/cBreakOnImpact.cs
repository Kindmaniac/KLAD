using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cBreakOnImpact : MonoBehaviour
{
    public float limit = 10;
    AudioSource audi;
    MeshRenderer mr;
    Collider colli;

    void Start()
    {
        audi = GetComponent<AudioSource>();
        mr = GetComponent<MeshRenderer>();
        colli = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.relativeVelocity.magnitude > limit)
        {
            audi.Play();
            mr.enabled = false;
            colli.enabled = false;
        }
    }
}
