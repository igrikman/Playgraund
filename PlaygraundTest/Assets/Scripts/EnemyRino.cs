using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRino : MonoBehaviour
{
    [SerializeField] private float speed = 11.0f;

    [SerializeField] private Rigidbody enemyRb;

    [SerializeField] private Transform player;
    [SerializeField] private NavMeshAgent navmesh;



    void Awake()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        navmesh = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        navmesh.destination = player.transform.position;
        //if  (gameObject.transform.position != player.transform.position)
        //{
        //    GetComponent<Animator>().Play("Walk");
        //}
    }
    
}
