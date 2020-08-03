using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject volOn;
    public GameObject volOff;
    public AudioSource bgVol;
    public bool isActive = true;
    void Awake()
    {
        //ResetAll();
        if (isActive)
        {
            PlayerPrefs.SetInt("CharacterVal", 1);
            PlayerPrefs.SetInt("BGVolume", 1);
            isActive = false;
        }
       
    }
    public void Play()
    {
        //SceneManager.LoadScene("Level Selections");
        SceneManager.LoadSceneAsync("Level Selections");
    }
    public void CharacterSelection()
    {
        //SceneManager.LoadScene("CharacterSelection");
        SceneManager.LoadSceneAsync("CharacterSelection");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void volumeOn()
    {
        volOn.SetActive(true);
        volOff.SetActive(false);
        bgVol.volume = 0f;
        PlayerPrefs.SetInt("BGVolume", 0);

    }
    public void volumeOff()
    {
        volOn.SetActive(false);
        volOff.SetActive(true);
        bgVol.volume = 1f;
        PlayerPrefs.SetInt("BGVolume", 1);
        
    }
    public void ResetAll()
    {
        PlayerPrefs.SetInt("LevelIndex", 1);
        for (int i = 1; i <= 6; i++)
        {
            PlayerPrefs.SetInt("Lv" + i, 0);
        }

    }
}
