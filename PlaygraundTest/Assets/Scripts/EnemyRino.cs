using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRino : MonoBehaviour
{
    [SerializeField] private float speed = 11.0f;

    [SerializeField] private Rigidbody enemyRb;

    [SerializeField] private Transform player;
    

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
      
    }
    public void Die() => Destroy(gameObject);
}
