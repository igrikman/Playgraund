using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    public GameObject player;


    private void OnCollisionEnter(Collision EnemyCol)
    {
        if (EnemyCol.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0f);
        }
    }
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
    }
}
