using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpAppear : MonoBehaviour
{
    [SerializeField] private SpriteRenderer customImage; //Sets to show in inspector
        private void OnTriggerEnter2D(Collider2D other) //Checks if something collides with gameObject
    {
        if (other.CompareTag("Player")) //Checks if the thing colliding with the gameObject has the tag "Player" assigned
        {
            customImage.enabled = true; //Enables sprite called "customeImage"
        }
    }
}
