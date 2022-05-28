using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cGoal : MonoBehaviour
{
    public string nextLevel;
    public float countdown = 2;
    float timer = 0;
    bool hit = false;
    AudioSource audi;

    
    
    void Start()
    {
        audi = GetComponent<AudioSource>();
    }

   


    void Update()
    {
        if (hit) timer += Time.deltaTime;
        if (timer > countdown) SceneManager.LoadScene(nextLevel);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Malte") && !hit)
        {
            audi.Play();
            Destroy(other.gameObject);
            hit = true;

        }
    }

    public void DieAndMoveOn()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
