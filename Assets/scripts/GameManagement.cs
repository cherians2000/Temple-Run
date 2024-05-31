using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagement : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject canvasToActivate;
    public GameObject skipToInactive;
    public float InactivationDelay = 30f;
  
    void Start()
    {
        StartCoroutine(inActivateSkipAfterDelay());
         
   }
    IEnumerator inActivateSkipAfterDelay()
    {
        // Wait for the specified delay duration.
        yield return new WaitForSeconds(InactivationDelay);
        skipToInactive.SetActive(false);
  
     
    }
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
    
    public void Menu()
    {
        SceneManager.LoadScene("MenuScreen");
      
    }
    public void playnext()
    {
        SceneManager.LoadScene("Level");

    }


}
