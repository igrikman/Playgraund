using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class GameController : MonoBehaviour
    {
        private ManagerBonus mBonus;
        [SerializeField] private GameObject bonus;
        //[SerializeField] private float speed = 11.0f;
        [SerializeField] private WariorController player;
        [SerializeField] private EnemyRino bigEnemyPrefab;
        [SerializeField] private EnemyRino fastEnemyPrefab;
        private List<EnemyRino> enemyListRino;
        [SerializeField] private float spawnTime = 3f;
        [SerializeField] private Transform[] spawnPoints;

        void Start()
        {
            InvokeRepeating("Spawn", spawnTime, spawnTime);
            enemyListRino = new List<EnemyRino>();

        }
        public void Spawn()
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
            player.ScoreCoin(5);
            Destroy(enemy.gameObject, 2f);
            SpawnBonus(enemy);
        }
        public void SpawnBonus(EnemyRino enemy)
        {
            var bonusSpawnRandIndex = Random.Range(0, 101);

            if (bonusSpawnRandIndex >= 0 && bonusSpawnRandIndex < 40)
            {
                var Bonus = Instantiate(bonus);
                Bonus.transform.position = enemy.transform.position;
                Debug.LogWarning("bonus");
            }

            if (bonusSpawnRandIndex >= 41 && bonusSpawnRandIndex < 101)
            {
                Debug.LogWarning("Ни хуя");
            }
        }
        public void Bonus()
        {
            var bonusRandIndex = Random.Range(0, 11);
            if (bonusRandIndex >= 0 && bonusRandIndex < 6)
            {
                Score();
                Debug.LogWarning("очко 100");

            }
            if (bonusRandIndex >= 7 && bonusRandIndex < 11)
            {
                Speed();
                Debug.LogWarning("скорость");

            }
        }


        //public void OnCollisionEnter(WariorController player)
        //{
        //    if (player.gameObject.tag == "Bonus")
        //    {
        //        Bonus();
        //    }
        //}

        public void Score()
        {
            
            
                Debug.LogWarning("Score");
                player.ScoreCoin(100);
            
        }
        public void Speed()
        {
            
            
                Debug.LogWarning("Speed");
                player.Speed(6f);
            
        }







    }
}