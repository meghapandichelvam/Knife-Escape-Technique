using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D Rb;
    private Animator PlayerAC;
    public float jumpForce = 5f;
    public static bool isDead = false;
   
    void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
        PlayerAC = GetComponent<Animator>();
    }

   
    void Update()
    {
        if (isDead)
            return;

        Jump();
        
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
        }
    }
}
