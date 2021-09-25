using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;                          //This needs to added

public class MainMenu : MonoBehaviour {

	
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");                  //Will Load the Main Gameplay Scene

    }
    public void QuitGame()
	{
		Application.Quit ();                            //Will Exit the Game
	}

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

}
