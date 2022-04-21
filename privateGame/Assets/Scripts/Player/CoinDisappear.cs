using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Allows user to use TMPro directive, such as TextMeshProUGUI

public class CoinDisappear : MonoBehaviour
{
    public TextMeshProUGUI textCoins; //Displays to inspector for user to connect to another gameObject
    [SerializeField] private AudioClip coinPickup; //Displays to inspector for user to select audioClip
    private AudioSource source; //Declares "source" as an AudioSource component
    private float coin; //Declares float variable coin

    private void Start()
    {
        source = GetComponent<AudioSource>(); //Sets "source" to be a shortcut for "GetComponent<AudioSource>();"
    }

    private void OnTriggerEnter2D(Collider2D other) //Checks if something collides with the trigger
    {
        if(other.transform.CompareTag("Coin")) //Checks if the item collided with has the tag "Coin"
        {
            coin++; //Coin + 1
            textCoins.text = coin.ToString(); //Sets the integer to string so it can be used
            

            source.PlayOneShot(coinPickup, 0.1f); //Plays audio component that the user decides on in inspector
            Destroy(other.gameObject); //Destroys the coin
        }
            
        if (other.transform.CompareTag("rndCoin"))
        {
            coin++; //Coin + 1
            textCoins.text = coin.ToString(); //Sets the integer to string so it can be used

            Destroy(other.gameObject); //Destroys the coin
        }

    }

    

}
