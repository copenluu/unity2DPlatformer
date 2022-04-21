using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void ChangeSceneByName(string MainGame)
    {
        if (name != null)
        {
            SceneManager.LoadScene(MainGame);
        }
    }


    public void CloseGame()
    {
        Application.Quit();
    }
}
