using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Obstacle;
    private float maxY = 5f, minY = -3f;
   
    void Start()
    {
        StartCoroutine(StartSpawning());
    }
    void Update()
    {
        if(PlayerJump.isComplete ||PlayerJump.isDead)
        {
            this.gameObject.SetActive(false);
        }
    }
   
    IEnumerator StartSpawning()
    {
        if (PlayerJump.isDead != true || PlayerJump.isComplete != true)
        {
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            Instantiate(Obstacle);
            float y = Random.Range(minY, maxY);
            Obstacle.transform.position = new Vector2(transform.position.x, y);
            StartCoroutine(StartSpawning());
        }
    }

   
}
