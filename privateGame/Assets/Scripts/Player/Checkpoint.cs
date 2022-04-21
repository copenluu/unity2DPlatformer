using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    LevelManager lm;
    

    private void Start()
    {
        lm = GameObject.FindGameObjectWithTag("LM").GetComponent<LevelManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            lm.lastCheckPointPos = transform.position;
        }
    }
}
