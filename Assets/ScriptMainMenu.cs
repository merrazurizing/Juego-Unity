using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMainMenu : MonoBehaviour
{
    public void playGame() {
        SceneManager.LoadScene("Card1");
        ScoreScript.resetScore();
    }

    public void backMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void quitGame() {
        Application.Quit();
    }


}