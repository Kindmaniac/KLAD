using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cCoin : MonoBehaviour
{
    cCoinManager manager;
    void Start()
    {
        manager = GetComponentInParent<cCoinManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        manager.ClearCoin(this.gameObject);
    }
}
