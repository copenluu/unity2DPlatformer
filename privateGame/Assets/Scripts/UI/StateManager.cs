using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateManager : MonoBehaviour
{
    [SerializeField] private GameObject thePlayer;
    Hearts findhearts;
    LevelManager lm;
    Player invuln;

    [SerializeField] GameObject OpenGamePanel;
    [SerializeField] GameObject OpenResetButton;

    private void Awake()
    {
        invuln = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        findhearts = GameObject.FindGameObjectWithTag("Player").GetComponent<Hearts>();
        lm = GameObject.FindGameObjectWithTag("LM").GetComponent<LevelManager>();
    }
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CheckpointRespawn()
    {
        GetComponent<UIManager>().ToggleDeathPanel();
        findhearts.health = 5;
        thePlayer.SetActive(true);
        thePlayer.transform.position = lm.lastCheckPointPos;
        StartCoroutine(invuln.Invulnerability());
        OpenGamePanel.SetActive(true);
        OpenResetButton.SetActive(true);
    }


    public void CloseGame()
    {
        Application.Quit();
    }

    public void ChangeSceneByName(string name)
    {
        if (name != null)
        {
            SceneManager.LoadScene(name);
        }
        
    }
}
