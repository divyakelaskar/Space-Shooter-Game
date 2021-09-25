using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverManager : MonoBehaviour
{

    public GameObject restartText; // Assign in inspector
    public GameObject menuText;     // Assign in inspector

    //  public GameObject Player;

    void FixedUpdate ()
	{

        UIvisible();
    }

   
	void Update ()
	{


        playerDestroyed();
        
	}

    void playerDestroyed() {

        GameObject[] player;
        player = GameObject.FindGameObjectsWithTag("Player");

        if (player.Length == 0 && Input.GetKeyDown(KeyCode.Escape))         // Checks if the player is not present and if the Escape key is pressed, it will load the Menu Scene
        {
            SceneManager.LoadScene("Menu");
        }
        else if (player.Length == 0 && Input.GetKeyDown(KeyCode.R))         //Checks if the player is not present and if the R key is pressed, it will load the GamePlay Scene i.e S1 from beginning
        {
            SceneManager.LoadScene("S1");
        }

        

    }
    void UIvisible() {


        GameObject[] player;
        player = GameObject.FindGameObjectsWithTag("Player");               
        if (player.Length == 0)
        {
            
            restartText.SetActive(true);            //Sets the Text Visible from Canvas
            menuText.SetActive(true);                //Sets the Text Visible from Canvas
        }
    }
   

   
}