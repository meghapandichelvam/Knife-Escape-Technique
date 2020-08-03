using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeBG : MonoBehaviour
{
    public GameObject[] LevelBG;
    public GameObject boy;
    public GameObject girl;

    public static int LevelIndex;
    public static int CharacterSelection;
    public GameObject CompleteWindow;
    public GameObject GameOverWindow;
    public GameObject GameComplete;
    public Text ScoreText;
    void Start()
    {
        Reset();
        GetBG();
        LevelIndex = PlayerPrefs.GetInt("LevelIndex");
        CharacterSelection = PlayerPrefs.GetInt("CharacterVal");
        GetCharacter();
    }


    void Update()
    {
        GetBG();
        if (PlayerJump.isComplete == true)
        {
            if(LevelIndex ==6)
            {
                GameComplete.SetActive(true);
            }else
            {
                CompleteWindow.SetActive(true);
            }
           
        }
        if (PlayerJump.isDead == true)
        {
            GameOverWindow.SetActive(true);
        }
        if(PlayerJump.isComplete != true || PlayerJump.isDead != true)
        {
            ScoreText.text = KnifeScript.escapeval.ToString();
            ScoreText.text += "/" + PlayerJump.WinCount.ToString();
        }
      
    }
    public void GetBG()
    {
        if (LevelIndex == 1)
        {
            LevelBG[0].SetActive(true);
            PlayerJump.WinCount = 6;
        }
        else if (LevelIndex == 2)
        {
            LevelBG[1].SetActive(true);
            PlayerJump.WinCount = 8;
        }
        else if (LevelIndex == 3)
        {
            LevelBG[2].SetActive(true);
            PlayerJump.WinCount = 10;
        }
        else if (LevelIndex == 4)
        {
            LevelBG[3].SetActive(true);
            PlayerJump.WinCount = 12;
        }
        else if (LevelIndex == 5)
        {
            LevelBG[4].SetActive(true);
            PlayerJump.WinCount = 14;
        }
        else if (LevelIndex == 6)
        {
            LevelBG[5].SetActive(true);
            PlayerJump.WinCount = 16;
        }
    }
    public void GetCharacter()
    {
        Debug.Log(PlayerPrefs.GetInt("CharacterVal"));
        if (CharacterSelection == 1)
        {

            Instantiate(girl);
            Reset();
        }
        else if (CharacterSelection == 2)
        {

            Instantiate(boy);
            Reset();

        }
    }

    public void Reset()
    {
        KnifeScript.escapeval = 0;
        PlayerJump.isDead = false;
        PlayerJump.isComplete = false;
    }
}
