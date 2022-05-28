using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cCoinManager : MonoBehaviour
{
    public List<GameObject> coins;
    public List <cAutoRotate> doors;
    AudioSource audi;
    public AudioClip noice;
    bool opened = false;
    void Start()
    {
        audi = GetComponent<AudioSource>();
        foreach (Transform child in transform)
        {
            coins.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (coins.Count <= 0 && !opened)
        {
            foreach (cAutoRotate door in doors)
            {
                door.rotation *= -1;
                door.timePassed = 0;
            }
            opened = true;
            audi.clip = noice;
            audi.Play();
        }
    }

    public void ClearCoin(GameObject coin)
    {
        coins.Remove(coin);
        coin.SetActive(false);
        audi.Play();
    }
}
