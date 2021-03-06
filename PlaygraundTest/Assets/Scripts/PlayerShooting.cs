﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace Game
{
    public class PlayerShooting : MonoBehaviour
    {
        public int damagePerShot = 20;
        public float timeBetweenBullets = 0.15f;
        public float Range = 100f;
        public AudioSource _audioSource;

        float timer;
        Ray shootRay;
        RaycastHit shootHit;

        ParticleSystem gunParticles;
        LineRenderer gunLine;
        public AudioSource gunAudio;
        Light gunLight;
        float effectsDisplayTime = 0.2f;

        private void Awake()
        {
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

                if (Physics.Raycast(shootRay, out shootHit, Range))
                {
                    EnemyRino enemyHealth = shootHit.collider.GetComponent<EnemyRino>();

                    if (enemyHealth != null)
                    {
                        enemyHealth.TakeDamage(damagePerShot, shootHit.point);
                    }
                    gunLine.SetPosition(1, shootHit.point);
                }
                else
                {
                    gunLine.SetPosition(1, shootRay.origin + shootRay.direction * Range);
                }
                Debug.Log(shootHit.collider != null ? "Попал в " + shootHit.collider : "No target");
            }
        }


    }
}

