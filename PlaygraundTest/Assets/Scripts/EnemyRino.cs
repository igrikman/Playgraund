using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace Game
{
    public class EnemyRino : MonoBehaviour
    {
        [SerializeField] private int startingHealth = 20;
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody enemyRb;
        [SerializeField] private Transform player;
        [SerializeField] private NavMeshAgent navmesh;
        CapsuleCollider capsuleCollider;

        public bool IsDead = false;

        private int currentHealth;
        private Animator myAnimator;
        private float distance;
        private bool sawPlayer = false;

        private void Awake()
        {
            myAnimator = GetComponent<Animator>();
            navmesh = GetComponent<NavMeshAgent>();
            capsuleCollider = GetComponent<CapsuleCollider>();
            currentHealth = startingHealth;
        }

        void Update()
        {
            if (player != null && !IsDead)
            {
                distance = Vector3.Distance(player.position, transform.position);

                if (distance <= 30)
                {

                    navmesh.enabled = true;
                    navmesh.SetDestination(player.position);
                    myAnimator.SetBool("Walk", true);
                    myAnimator.SetBool("Idle", false);
                    sawPlayer = true;
                }
                else if (sawPlayer == false)
                {
                    myAnimator.SetBool("Walk", false);
                    myAnimator.SetBool("Idle", true);
                    navmesh.enabled = false;
                }

            }
            else if (player == null)
            {
                myAnimator.SetBool("Walk", false);
                myAnimator.SetBool("Idle", true);
                navmesh.enabled = false;
            }
            else if (IsDead)
            {
                navmesh.enabled = false;
                capsuleCollider.enabled = false;
            }

        }

        public void SetPlayer(Transform playerTransform)
        {
            player = playerTransform;
        }

        public void TakeDamage(int amount, Vector3 hitPoint)
        {
            Debug.LogWarning("Получил дамаг");
            if (IsDead)
                return;

            currentHealth -= amount;

            if (currentHealth <= 0)
            {
                Debug.LogWarning("умер рино");
                IsDead = true;

                capsuleCollider.isTrigger = true;

                myAnimator.SetTrigger("Dead");

            }
        }
    }

}