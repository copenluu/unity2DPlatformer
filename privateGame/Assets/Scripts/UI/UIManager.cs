using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject DeathPanel; //Exposes to inspector
    

    public void ToggleDeathPanel() //Creates "ToggleDeathPanel" Method/Function
    {
        DeathPanel.SetActive(!DeathPanel.activeSelf); //DeathPanel sets itself to the opposite of whatever it is currently
    }

    
}
