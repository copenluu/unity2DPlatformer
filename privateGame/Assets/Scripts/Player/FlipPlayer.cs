using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipPlayer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer play;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            play.flipX = false; 
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            play.flipX = true;
        }
    }
}
