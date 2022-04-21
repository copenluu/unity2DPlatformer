using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseHealth : MonoBehaviour
{
    [SerializeField] private AudioClip healthSound;
    Hearts dahealth;

    private AudioSource healthSource;


    private void Start()
    {
        dahealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Hearts>();
        healthSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (dahealth.health != 5)
        {
            if (other.CompareTag("heart"))
            {
                dahealth.health++;
                healthSource.PlayOneShot(healthSound, 0.7f);
                Destroy(other.gameObject);
            }
        }
    }




}
