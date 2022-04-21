using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBallDamage : MonoBehaviour
{
    Player player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Diagonal") || other.transform.CompareTag("Player"))
        {
            if (other.transform.CompareTag("Player"))
            {
                player.Damage();
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
