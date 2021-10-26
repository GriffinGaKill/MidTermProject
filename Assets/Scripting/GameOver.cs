using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Setup(int score)
    {
        gameObject.SetActive(true);
    }
    public void RestarttButton()
    {
        SceneManager.LoadScene("Main Game");
    }
        
    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
