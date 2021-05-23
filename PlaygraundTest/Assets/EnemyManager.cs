using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class EnemyManager : MonoBehaviour
    {
        //ЗАМЕНИТЬ ПЕРВУЮ БУКВУ В ПАБЛИК ПОЛЯХ НА ЗАГЛАВНУЮ
        public Player player;
        public GameObject enemy;
        public float spawnTime = 3f;
        public Transform[] spawnPoints;


        void Start()
        {
            InvokeRepeating("Spawn", spawnTime, spawnTime);
        }


        void Spawn()
        {
            if (player.currentHealth <= 0f)
            {
                return;
            }

            int spawnPointIndex = Random.Range(0, spawnPoints.Length);

            Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }
}
