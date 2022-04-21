using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXScript : MonoBehaviour {

    [SerializeField] private AudioSource Scream;

    public void PlayScream()
    {
        Scream.Play();
    }


}
