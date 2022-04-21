using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballRight : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody2D rb;
    Player player;





    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            player.Damage();
        }
        if (other.transform.CompareTag("heart"))
        {
            return;
        }
        if (other.transform.CompareTag("Coin"))
        {
            return;
        }
        Destroy(gameObject);
    }
}