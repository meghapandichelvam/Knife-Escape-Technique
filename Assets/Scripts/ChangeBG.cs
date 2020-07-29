using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBG : MonoBehaviour
{
    public GameObject[] LevelBG;
    public GameObject boy;
    public GameObject girl;

    public static int LevelIndex;
    public static int CharacterSelection;
    public GameObject CompleteWindow;
    public GameObject GameOverWindow;

    void Start()
    {
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
            CompleteWindow.SetActive(true);
        }
        if (PlayerJump.isDead == true)
        {
            GameOverWindow.SetActive(true);
        }

    }
    public void GetBG()
    {
        if (LevelIndex == 1)
        {
            LevelBG[LevelIndex - 1].SetActive(true);
            PlayerJump.WinCount = 5;
        }
        else if (LevelIndex == 2)
        {
            LevelBG[LevelIndex - 1].SetActive(true);
            PlayerJump.WinCount = 8;
        }
        else if (LevelIndex == 3)
        {
            LevelBG[LevelIndex - 1].SetActive(true);
            PlayerJump.WinCount = 10;
        }
        else if (LevelIndex == 4)
        {
            LevelBG[LevelIndex - 1].SetActive(true);
            PlayerJump.WinCount = 12;
        }
        else if (LevelIndex == 5)
        {
            LevelBG[LevelIndex - 1].SetActive(true);
            PlayerJump.WinCount = 14;
        }
        else if (LevelIndex == 6)
        {
            LevelBG[LevelIndex - 1].SetActive(true);
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
