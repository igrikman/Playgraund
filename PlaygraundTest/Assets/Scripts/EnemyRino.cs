using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace Game
{
    public class EnemyRino : MonoBehaviour
    {
        private Animator myAnimator;
        private float distance;

        [SerializeField] private float speed;
        [SerializeField] private Rigidbody enemyRb;
        [SerializeField] private Transform player;
        [SerializeField] private NavMeshAgent navmesh;

        private void Start()
        {
            myAnimator = GetComponent<Animator>();
            navmesh = GetComponent<NavMeshAgent>();
        }
        void Update()
        {
            if (player != null)
            {
                distance = Vector3.Distance(player.position, transform.position);

                //if (distance > 100)
                //{
                //    transform.LookAt(player.position);
                //    navmesh.enabled = false;
                //    myAnimator.SetBool("Walk", false);
                //    myAnimator.SetBool("Idle", true);

                //}
                if (distance <= 80 & distance > 1.5f)
                {
                    navmesh.enabled = true;
                    navmesh.SetDestination(player.position);
                    myAnimator.SetBool("Walk", true);
                    myAnimator.SetBool("Idle", false);

                }
            }
        }

    }
}