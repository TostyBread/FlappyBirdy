using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void StartGame()//To Start Game
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Return()//To Main Menu
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Credits()//To Credits
    {
        SceneManager.LoadScene("Credits");
    }

    public void Controls()//To Controls
    {
        SceneManager.LoadScene("Crontrols");
    }

}
