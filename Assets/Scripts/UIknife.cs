using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIknife : MonoBehaviour
{
    public bool moveRight;
    public float speed;

    void Update()
    {
        Move();
    }
    void Move()
    {
        if (moveRight)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
        }
        else
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;
        }
    }
    private void OnTriggerEnter2D(Collider2D Target)
    {
        if (Target.tag == "UIKnife")
        {

            Destroy(this.gameObject);
        }
        if (Target.tag == "UIKnife")
        {

            Destroy(this.gameObject);
        }
    }
}
