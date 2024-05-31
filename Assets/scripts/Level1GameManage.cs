using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level1GameManage : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject canvasToActivate;
   
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // You can change this key as needed.
        {
            TogglePause();
        }
    }
    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            // Pause the game.
            Time.timeScale = 0;
            canvasToActivate.SetActive(true);
        }
        else
        {
            // Resume the game.
            Time.timeScale = 1;
            canvasToActivate.SetActive(false);

        }

    }
    public void RestartScene()
    {
        Debug.Log("restarted");
        // Get the name of the current scene.
        int currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene by build index.
        SceneManager.LoadScene(currentSceneBuildIndex);
    }
    public void Menu()
    {
        Debug.Log("menu");
        // Get the name of the current scene.
       

        // Reload the current scene by name.
        SceneManager.LoadScene("MenuScreen");
    

    }
    public void OnApplicationQuit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

}
