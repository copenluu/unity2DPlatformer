using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpDisappear : MonoBehaviour
{
    [SerializeField] private SpriteRenderer ImageDisappear; //Declares to inspector

    private void OnTriggerEnter2D(Collider2D collision) //Checks if something collides with gameObject
    {
        if (collision.CompareTag("Player")) //Checks if item colliding with has the tag "Player"
        {
            ImageDisappear.enabled = false; //Disables sprite linked to "ImageDisappear"
        }
    }
    
}
