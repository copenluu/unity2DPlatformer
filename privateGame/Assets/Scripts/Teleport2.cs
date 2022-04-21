using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
{
    [SerializeField] private GameObject playersprite;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        playersprite.transform.position = new Vector2(-58.8f, -73.49f);
    }
}
