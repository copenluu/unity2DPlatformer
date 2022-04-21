using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour
{
    public static LevelManager instance; //Declares to inspector and can be called from other scripts
    public Vector2 lastCheckPointPos;
    [SerializeField] GameObject CloseGamePanel;
    [SerializeField] GameObject CloseResetButton;



    private void Awake() //On start up
    {
        if (LevelManager.instance == null)
        {
            instance = this; //If this instance already exists, make it to LevelManager this instance
            
        } 
        else
        {
            Destroy(gameObject); //Else, destroy gameObject
        } 
    }

    public void GameOver() //Sets method "GameOver" to public
    {
        UIManager _ui = GetComponent<UIManager>(); //Gets the UIManager script. Simialr to Rigidbody2D rigidbody
        if (_ui != null) //if _ui does not equal null
        {
            _ui.ToggleDeathPanel(); //Calls method from UIManager script // aka GetCompononent<UIManager>().ToggleDeathPanel();
            CloseGamePanel.SetActive(false);
            CloseResetButton.SetActive(false);
        }
    }

}
