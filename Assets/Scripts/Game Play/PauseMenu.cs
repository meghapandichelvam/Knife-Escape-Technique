﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Toggle();
        }

    }

    public void Toggle()
    {
        pauseMenuUI.SetActive(!pauseMenuUI.activeSelf);
        if (pauseMenuUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Quit()
    {
      
        Application.Quit();        
    }
    public void Retry()
    {
      
        Debug.Log("Retry");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
    public void Next()
    {
       
        Debug.Log("Next");
        //SceneManager.LoadScene("Level Selections");
        SceneManager.LoadSceneAsync("Level Selections");
    }
    public void Menu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
        Debug.Log("MainMEnu");

    }
}
