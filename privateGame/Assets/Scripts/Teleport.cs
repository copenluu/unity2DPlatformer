using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject playersprite;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playersprite.transform.position = new Vector2(-29.04f, -72.5f);
    }
}
