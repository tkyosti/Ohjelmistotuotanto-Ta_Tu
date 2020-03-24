using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuController : MonoBehaviour
{
    // Load the game scene
    public void playGame() {
        SceneManager.LoadScene("gameBoardScene");
    }
    // Open the information of game
    public void info() {
        
    }
    // Shut the game
    public void exitGame() {
        Application.Quit();
    }
}