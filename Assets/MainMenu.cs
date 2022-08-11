using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //This function causes the player to move to the Level Selector scene. 
    //This happens when the player selects the Level Selector button (in the main menu).
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    //Quits the game.
    public void Exit()
    {
        Debug.Log("Exitting...");

        Application.Quit();
    }
}
