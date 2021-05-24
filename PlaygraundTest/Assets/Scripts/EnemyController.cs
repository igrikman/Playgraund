using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class EnemyController : MonoBehaviour
    {
        
        [SerializeField] private float speed = 11.0f;
        [SerializeField] private Player player;
        [SerializeField] private EnemyRino bigEnemyPrefab;
        [SerializeField] private EnemyRino fastEnemyPrefab;
        private List<EnemyRino> enemyListRino;
        [SerializeField] private float spawnTime = 3f;
        [SerializeField] private Transform[] spawnPoints;
        private EnemyRino Remove;


        void Start()
        {
            InvokeRepeating("Spawn", spawnTime, spawnTime);
            enemyListRino = new List<EnemyRino>();
        }


        void Spawn()
        {
            if (player.currentHealth <= 0f)
            {
                return;
            }

            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            
            if (Random.Range(0, 1) > 0)
            {
                var enemy = Instantiate(bigEnemyPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                enemy.SetPlayer(player.transform);
                enemyListRino.Add(enemy);
            }
            else
            {
                var enemy = Instantiate(fastEnemyPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                enemy.SetPlayer(player.transform);
                enemyListRino.Add(enemy);
            }
        }

        private void Update()
        {
            foreach (var enemy in enemyListRino)
            {
                if (enemy.IsDead)
                {
                    RemoveEnemy(enemy);
                }
            }
        }
        public void Death(EnemyRino enemy)
        {
            Destroy(enemy.gameObject, 5f);
        }
        public void RemoveEnemy(EnemyRino enemy)
        {
            enemyListRino.Remove(enemy);
            Death(enemy);
        }
    }
}
