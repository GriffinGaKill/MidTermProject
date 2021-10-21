using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused == true)
        {
            //unpause
            Time.timeScale = 1.0f;

            //Hides the button when the game is unpaused
            pauseUI.SetActive(false);

            //When ispaused is true, this line will set it to false
            isPaused = false;
        }
        else
        {
            //pause
            Time.timeScale = 0.0f;

            //Shows the button when the gae  is paused
            pauseUI.SetActive(true);

            //When is false, this line will set it to true
            isPaused = true;
        }

        //Sets ispaused to the opposite of what it is right now
        isPaused = !isPaused;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
