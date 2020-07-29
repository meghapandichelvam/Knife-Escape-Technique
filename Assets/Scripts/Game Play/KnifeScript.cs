using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{

    public bool moveRight;
    private float speed = 2f;
    public static int escapeval = 0;
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        if(moveRight)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
        }else
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;
        }
    }
    private void OnTriggerEnter2D(Collider2D Target)
    {
        if(Target.tag =="LeftWall")
        {
            escapeval++;
            Debug.Log("Right trigger" + escapeval);
            Destroy(this.gameObject);
        }
        if (Target.tag == "RightWall")
        {
            escapeval++;
            Debug.Log("Right trigger"+ escapeval);
            Destroy(this.gameObject);
        }
    }
}
