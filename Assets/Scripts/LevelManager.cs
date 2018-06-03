using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    public void LoadLevel(string levelName)
    {
        Brick.BrickCount = 0;
        SceneManager.LoadScene(levelName);
    }
    
    public void ReturnToStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void WinTheGame()
    {
        SceneManager.LoadScene("Win");
    }
    
    public void LoseTheGame()
    {
        SceneManager.LoadScene("Start");
    }

    public void LoadNextLevel()
    {
//        Application.LoadLevel(Application.loadedLevel + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
    }

    public void BrickDestroyed()
    {
        if (Brick.BrickCount <= 0)
        {
            LoadNextLevel();
        }
    }
}

