using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}