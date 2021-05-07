using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRino : MonoBehaviour
{
    private Animator myAnimator;
    private float distance;
    

    [SerializeField] private float speed = 11.0f;
    [SerializeField] private Rigidbody enemyRb;
    [SerializeField] private Transform player;
    [SerializeField] private NavMeshAgent navmesh;
    private void Start()
    {
        myAnimator = GetComponent<Animator>();
        navmesh = GetComponent<NavMeshAgent>();
    }
    //private void OnCollisionEnter(Collision RinoCol)
    //{
    //    if (RinoCol.gameObject.tag == "Player")
    //    {
    //        GetComponent<Animator>().Play("Attack");
    //        Debug.LogError("Атакую");
    //    }
    //}

    //void Awake()
    //{
    //    //player = GameObject.FindGameObjectWithTag("Player").transform;
    //    navmesh = GetComponent<NavMeshAgent>();
    //}
    void Update()
    {
        distance = Vector3.Distance(player.position, transform.position);

        //if(distance > 20)
        //{
        //    transform.LookAt(player.position);
        //    navmesh.enabled = false;
        //    myAnimator.SetBool("Walk",false);
        //    myAnimator.SetBool("Attack", false);

        //}
        if (distance <= 8 & distance >1.5f)
        {    
            navmesh.enabled = true;
            navmesh.SetDestination(player.position);
            myAnimator.SetBool("Walk",true);
            myAnimator.SetBool("Attack", false);

        }
        if (distance <= 1.5f)
        {
            navmesh.enabled = false;
            myAnimator.SetBool("Attack",true);
            myAnimator.SetBool("Walk", false);

        }


        //navmesh.destination = player.transform.position;
        //if (gameObject.transform.position != player.transform.position)
        //{
        //    GetComponent<Animator>().Play("Walk");
        //}
        //else
        //{
        //    navmesh.enabled = false;
        //    Debug.LogError("Не иду");
        //}
    }

}
