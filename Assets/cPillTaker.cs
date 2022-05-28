using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cPillTaker : MonoBehaviour
{
    public ConstantForce conny;
    AudioSource audi;

    private void Start()
    {
        audi = GetComponent<AudioSource>();

    }
    public void MakeMeDoIt(Vector3 forcy, Vector3 torqi){
        conny.force = forcy;
        conny.torque = torqi;
        audi.Play();
    }

}
