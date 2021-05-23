using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace Game
{
    public class EnemyHealth : MonoBehaviour
    {

        [SerializeField] private int startingHealth = 2;

        [SerializeField] private AudioClip deathClip;

        private int currentHealth;

        private Animator anim;

        public float sinkSpeed = 2.5f;

        bool isDead = false;
        bool isSinking;

        //ParticleSystem hitParticles;
        CapsuleCollider capsuleCollider;

        private void Awake()
        {
            anim = GetComponent<Animator>();
            //hitParticles = GetComponentInChildren<ParticleSystem>();
            capsuleCollider = GetComponent<CapsuleCollider>();

            currentHealth = startingHealth;
        }
        private void Update()
        {
            if (isSinking)
            {
                transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
            }
        }


        public void TakeDamage(int amount, Vector3 hitPoint)
        {
            Debug.LogWarning("Получил дамаг");
            if (isDead)
                return;

            currentHealth -= amount;

            //hitParticles.transform.position = hitPoint;
            
            

            //hitParticles.Play();

            if (currentHealth <= 0)
            {
                Death();
                Debug.LogWarning("умер рино");
            }
        }
        public void Death()
        {
            isDead = true;

            capsuleCollider.isTrigger = true;

            anim.SetTrigger("Dead");
            StartSinking();
        }
        public void StartSinking()
        {
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;

            isSinking = true;
            //ScoreManager.score += scoreValue;

            Destroy(gameObject, 2f);
        }
    }
}
