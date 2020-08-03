using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class CharacterCollection : MonoBehaviour
{
    public GameObject SelectedBoy;
    public GameObject SelectedGirl;
   
    public void CharacterSelection(int val)
    {
        if(val ==1)
        {
            PlayerPrefs.SetInt("CharacterVal", 1);
            SelectedGirl.SetActive(true);
            SelectedBoy.SetActive(false);
        }
        else if(val ==2)
        {
            PlayerPrefs.SetInt("CharacterVal", 2);
            SelectedGirl.SetActive(false);
            SelectedBoy.SetActive(true);
        }       
    }
    public void BackToMain()
    {
        Debug.Log("MainMenu");
        //SceneManager.LoadScene("Main Menu");
        SceneManager.LoadSceneAsync("Main Menu");
    }
    public void Play()
    {
        //SceneManager.LoadScene("Level Selections");
        SceneManager.LoadSceneAsync("Level Selections");
    }
}
