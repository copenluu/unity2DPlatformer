using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    public int health; //Declares health to inspector
    public int numOfHearts; //Declares numOfHearts to inspector

    [SerializeField] private Image[] hearts; //Allows users to set image for hearts in inspector
    [SerializeField] private Sprite fullHeart; //Declares sprites called fullHeart to inspector
    [SerializeField] private Sprite emptyHeart; //Declares sprites called emptyHeart to inspector

    public void Update()
    {
        if(health > numOfHearts) //If the health is greater than numOfHearts
        {
            health = numOfHearts; //health value int = numOfhearts
        }


        for (int i = 0; i < hearts.Length; i++) //For loop, declares variable "i" and = 0 ; while "i" is less than "hearts.Length, i + 1 
        {
            if (i < health) //Checks if "i" is less than health variable
            {
                hearts[i].sprite = fullHeart; //Sets the image for the hearts equal to how many "i" there is. If i = 5, 5 images will be "fullHeart". Sets image using sprites
            }
            else
            {
                hearts[i].sprite = emptyHeart; //Sets the image for the hearts equal to the lack of "i". If there is 4 "i" then one heart will be "emptyHeart". Sets image using sprites
            }


            if(i < numOfHearts) //if "i" is less than numOfHearts
            {
                hearts[i].enabled = true; //Enables
            }
            else
            {
                hearts[i].enabled = false; //Disables
            }
        }
    }



}
