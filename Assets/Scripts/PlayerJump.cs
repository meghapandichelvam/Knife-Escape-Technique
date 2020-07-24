using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D Rb;
    private Animator PlayerAC;

    public GameObject GameComplete;
    public GameObject GameOver;

    public int WinCount;
    public float jumpForce = 5f;
    public static bool isDead = false;
    public static bool isComplete = false;

    void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
        PlayerAC = GetComponent<Animator>();
        Reset();
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
                GameComplete.SetActive(true);
                this.gameObject.SetActive(false);
                isComplete = true;
            }
        }
      
 
    }
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rb.velocity = new Vector2(Rb.velocity.x, jumpForce);
            PlayerAC.SetTrigger("Jump");
        }
      
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag =="Knife")
        {
            PlayerPrefs.SetInt("PlayerScore", KnifeScript.escapeval);
            isDead = true;
            PlayerAC.SetTrigger("Dead");
            Debug.Log("Game Over"+ KnifeScript.escapeval);
            GameOver.SetActive(true);

        }
    }
    public static void  Reset()
    {
        KnifeScript.escapeval = 0;
        isDead = false;
    }
}
