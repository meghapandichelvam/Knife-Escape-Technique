using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SoundManager : MonoBehaviour
{
   
    public AudioSource BGVol;
    private int volVal;

    void Awake()
    {
      
        volVal = PlayerPrefs.GetInt("BGVolume");
        Debug.Log("vol val" + volVal);

    }
    void Update()
    {

        if (volVal == 1)
        {
            BGVol.volume = 1;
        }
        else if (volVal == 0)
        {
            BGVol.volume = 0;
        }
    }
    public void Menu()
    {
       // SceneManager.LoadScene("Main Menu");
        SceneManager.LoadSceneAsync("Main Menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
  
}
