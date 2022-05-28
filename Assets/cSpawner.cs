using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cSpawner : MonoBehaviour
{

    
    public float[] times;
    public GameObject[] spawns;

    bool[] spawnCheck;
    float timer = 0;

    void Start()
    {
        spawnCheck = new bool[times.Length];
        for (int i = 0; i < spawnCheck.Length; i++)
        {
            spawnCheck[i] = false;
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        for (int i = 0; i < times.Length; i++)
        {
            if (!spawnCheck[i] && timer > times[i])
            {
                spawns[i].SetActive(true);
                spawnCheck[i] = true;
            }
        }


    }
}
