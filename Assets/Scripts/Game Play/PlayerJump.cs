using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D Rb;
    private Animator PlayerAC;

    public static int WinCount;
    public float jumpForce = 5f;
    public static bool isDead = false;
    public static bool isComplete = false;
    

    void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
        PlayerAC = GetComponent<Animator>();
      
    }

   
    void Update()
    {
        if (isDead)
            return;

        if (isDead != true)
        {
            Jump();
            if (KnifeScript.escapeval >= WinCount)
            {
                Debug.Log("Won the game");                
                this.gameObject.SetActive(false);
                PlayerPrefs.SetInt("Lv" + PlayerPrefs.GetInt("LevelIndex"), 1);
                isComplete = true;
                //Debug.Log(PlayerPrefs.GetInt("Lv" + PlayerPrefs.GetInt("LevelIndex")));
                //Debug.Log("escape val" + KnifeScript.escapeval + "wincount" + WinCount);
            }
        }
      


    }
    void Jump()
    {
        //#region PC
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Rb.velocity = new Vector2(Rb.velocity.x, jumpForce);
        //    PlayerAC.SetTrigger("Jump");
        //}
        //#endregion
        #region Android
        if (Input.GetMouseButtonDown(0))
        {
            Rb.velocity = new Vector2(Rb.velocity.x, jumpForce);
            PlayerAC.SetTrigger("Jump");
        }
        #endregion
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag =="Knife")
        {
            PlayerPrefs.SetInt("PlayerScore", KnifeScript.escapeval);
            isDead = true;
            PlayerAC.SetTrigger("Dead");
            Debug.Log("Game Over"+ KnifeScript.escapeval);           
            PlayerPrefs.GetInt("Lv" + ChangeBG.LevelIndex, 0);

        }
    }
  
}
