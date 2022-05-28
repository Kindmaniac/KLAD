using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cPill : MonoBehaviour
{

    public Vector3 forcy;
    public Vector3 torqi;
 

    private void OnTriggerEnter(Collider other)
    {
        cPillTaker user = other.GetComponentInParent<cPillTaker>();
        if (user != null) 
        { 
            user.MakeMeDoIt(forcy, torqi);
            gameObject.SetActive(false);
        }
    }

}
