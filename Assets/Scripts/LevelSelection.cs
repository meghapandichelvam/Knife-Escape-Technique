using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelSelection : MonoBehaviour
{
    [SerializeField] public bool unlocked;//Default value is false;


    public AudioSource Clip;
    [HideInInspector]
    public int LevelIndex;
    public Button levels;

  
    private void Update()
    {
        //ResetAll();       
        UpdateLevelImage();
        UpdateLevelStatus();

    }

    private void UpdateLevelStatus()
    {
        //if the current lv is 5, the pre should be 4
        int previousLevelNum = int.Parse(gameObject.name) - 1;
        if (PlayerPrefs.GetInt("Lv" + previousLevelNum.ToString()) > 0)//If the firts level star is bigger than 0, second level can play
        {
            unlocked = true;
        }


    }
    public void SetLevelIndex(int levelIndex)
    {
        PlayerPrefs.SetInt("LevelIndex", levelIndex);
    }
    private void UpdateLevelImage()
    {
        if (unlocked)//if unlock is true means This level can play 
        {

            levels.interactable = true;

        }
        else
        {

            levels.interactable = false;
        }
    }

    public void PressSelection() //When we press this level, we can move to the corresponding Scene to play
    {
        Clip.Play();
        SceneManager.LoadScene("KE Main");
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
