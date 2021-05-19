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

        [SerializeField] private float startingHealth;
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody enemyRb;
        [SerializeField] private Transform player;
        [SerializeField] private NavMeshAgent navmesh;
        [SerializeField] private AudioClip deathClip;

        bool Die;
        ParticleSystem hitParticles;
        CapsuleCollider capsuleCollider;
        AudioSource enemyAudio;

        private float currentHealth; 
        private void Start()
        {
            hitParticles = GetComponentInChildren<ParticleSystem>();
            capsuleCollider = GetComponent<CapsuleCollider>();

            currentHealth = startingHealth;

            myAnimator = GetComponent<Animator>();
            navmesh = GetComponent<NavMeshAgent>();
        }

        public void TakeDamage(int amount, Vector3 hitPoint)
        {
            if (Die)
                return;

            currentHealth -= amount;

            hitParticles.transform.position = hitPoint;

            hitParticles.Play();
            Debug.LogError("Получил дамаг");
            if(currentHealth <= 0)
            {
                
            }
        }
        void Death()
        {
            Die = true;

            capsuleCollider.isTrigger = true;

            myAnimator.SetTrigger("Die");

            enemyAudio.clip = deathClip;
            enemyAudio.Play();
        }

        void Update()
        {
            distance = Vector3.Distance(player.position, transform.position);

            if (distance > 100)
            {
                transform.LookAt(player.position);
                navmesh.enabled = false;
                myAnimator.SetBool("Walk", false);
                myAnimator.SetBool("Idle", true);

            }
            if (distance <= 80 & distance > 1.5f)
            {
                navmesh.enabled = true;
                navmesh.SetDestination(player.position);
                myAnimator.SetBool("Walk", true);
                myAnimator.SetBool("Idle", false);

            }





            //if (distance <= 1.5f)
            //{
            //    navmesh.enabled = false;
            //    myAnimator.SetBool("Attack",true);
            //    myAnimator.SetBool("Walk", false);

            //}


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
}