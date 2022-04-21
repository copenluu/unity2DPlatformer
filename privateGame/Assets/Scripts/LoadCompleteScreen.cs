using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCompleteScreen : MonoBehaviour
{

    [SerializeField] GameObject GameOverPanel;
    [SerializeField] GameObject CloseGamePanel;
    [SerializeField] GameObject CloseResetButton;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        GameOverPanel.SetActive(!GameOverPanel.activeSelf);
        StopAllCoroutines();
        CloseGamePanel.SetActive(!CloseGamePanel.activeSelf);
        CloseResetButton.SetActive(!CloseResetButton.activeSelf);  
    }
}
