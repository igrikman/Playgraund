using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class EnemyController : MonoBehaviour
    {

        //  private BonusController isBonus;
        [SerializeField] private GameObject bonus;
        [SerializeField] private float speed = 11.0f;
        [SerializeField] private WariorController player;
        [SerializeField] private EnemyRino bigEnemyPrefab;
        [SerializeField] private EnemyRino fastEnemyPrefab;
        private List<EnemyRino> enemyListRino;
        // private List<BonusController> bonusController;
        [SerializeField] private float spawnTime = 3f;
        [SerializeField] private Transform[] spawnPoints;
        



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
        public void RemoveEnemy(EnemyRino enemy)
        {
            enemyListRino.Remove(enemy);
            Death(enemy);
        }
        public void Death(EnemyRino enemy)
        {
            player.ScoreCoin(1);
            SpawnBonus(enemy);
            Destroy(enemy.gameObject, 2f);
        }
        //Bonus
        void SpawnBonus(EnemyRino enemy)
        {
            bonus.transform.position = enemy.transform.position;
            Instantiate(bonus); 
            
            Destroy(bonus.gameObject, 1f);
        }
        public void Bonus()
        {
            var bonusRandIndex = Random.Range(0, 100);

            if (bonusRandIndex >= 0 && bonusRandIndex < 15)
            {
                Score();
            }
            if (bonusRandIndex >= 16 && bonusRandIndex < 26)
            {
                DoubleSpeed();
            }
            if (bonusRandIndex >= 27 && bonusRandIndex < 32)
            {
                StopAll();
            }
            if (bonusRandIndex >= 33 && bonusRandIndex < 35)
            {
                DestroyAll();
            }
            if (bonusRandIndex >= 35 && bonusRandIndex < 100)
            {
                Debug.LogWarning("Ни хуя");
            }

        }
        public void Score()
        {
            Debug.LogWarning("Score");

        }
        public void DoubleSpeed()
        {
            Debug.LogWarning("DoubleSpeed");
            // Invoke("Bonus", 0.5f);
        }
        public void StopAll()
        {
            Debug.LogWarning("StopAll");
            // Invoke("Bonus", 0.5f);
        }
        public void DestroyAll()
        {
            Debug.LogWarning("DestroyAll");
            // Invoke("Bonus", 0.5f);
        }
    }
}