using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class PlayerShooting : MonoBehaviour
    {
        public int damagePerShot = 2;
        public float timeBetweenBullets = 0.15f;
        public float range = 100f;
        public AudioSource _audioSource;

        float timer;
        Ray shootRay;
        RaycastHit shootHit;

        int shootableMask;

        ParticleSystem gunParticles;
        LineRenderer gunLine;
        public AudioSource gunAudio;
        Light gunLight;
        float effectsDisplayTime = 0.2f;

        private void Awake()
        {
            shootableMask = LayerMask.GetMask("Shootable");

            gunParticles = GetComponent<ParticleSystem>();
            gunLine = GetComponent<LineRenderer>();
            gunAudio = GetComponent<AudioSource>();
            gunLight = GetComponent<Light>();
        }
        private void Update()
        {
            timer += Time.deltaTime;
            if (Input.GetButton("Fire1") && timer >= timeBetweenBullets)
            {
                Shoot();
            }
            if (timer >= timeBetweenBullets * effectsDisplayTime)
            {
                DisableEffects();
            }
            void DisableEffects()
            {
                gunLine.enabled = false;
                gunLight.enabled = false;
            }
            void Shoot()
            {
                timer = 0f;

                gunAudio.Play();
                gunLight.enabled = true;

                gunParticles.Stop();
                gunParticles.Play();

                gunLine.enabled = true;
                gunLine.SetPosition(0, transform.position);

                shootRay.origin = transform.position;
                shootRay.direction = transform.forward;

                Debug.Log("Я попал в" + shootHit.collider);

                if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
                {
                    EnemyRino enemyHealth = shootHit.collider.GetComponent<EnemyRino>();

                    if (enemyHealth != null)
                    {
                            enemyHealth.TakeDamage(damagePerShot, shootHit.point);
                        Debug.LogError("Получил дамаг");
                    }

                    gunLine.SetPosition(1, shootHit.point);
                }

                else
                {
                    gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
                }
            }
        }


    }
}

