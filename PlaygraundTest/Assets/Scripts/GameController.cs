using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private GameObject bonus;
        [SerializeField] private WariorController player;
        [SerializeField] private EnemyRino bigEnemyPrefab;
        [SerializeField] private EnemyRino fastEnemyPrefab;
        [SerializeField] private float spawnTime = 3f;
        [SerializeField] private Transform[] spawnPoints;

        private bool actBonus = false;
        private List<EnemyRino> enemyListRino;
        private GameObject[] gameObjects;
        void Start()
        {
            InvokeRepeating("Spawn", spawnTime, spawnTime);
            enemyListRino = new List<EnemyRino>();
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
        #region ENEMY
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

        public void RemoveEnemy(EnemyRino enemy)
        {
            enemyListRino.Remove(enemy);
            player.ScoreCoin(5);
            SpawnBonus(enemy);
            Destroy(enemy.gameObject, 2f);
        }
        #endregion
        #region BONUS
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
            //if (bonusRandIndex >= 1 && bonusRandIndex < 4)
            //{
            //    Score();
            //    Debug.LogWarning("очко 100");
            //}
            //if (bonusRandIndex >= 6 && bonusRandIndex < 11)
            //{
            //    Speed();
            //    Debug.LogWarning("скорость");
            //}
            //if (bonusRandIndex >= 12 && bonusRandIndex < 13)
            //{
            //    StopAll();
            //    Debug.LogWarning("заморозить мобов");
            //}
            if (bonusRandIndex >= 0 && bonusRandIndex < 11)
            {
                DestroyAll();
                Debug.LogWarning("уничтожить всех мобов");
            }
        }

        public void Score()
        {
            Debug.LogWarning("Score");
            player.ScoreCoin(100);
        }

        public void Speed()
        {
            Debug.LogWarning("Speed");
            player.Speed(6f);
            if (actBonus == false)
            {
                actBonus = true;
                StartCoroutine(timeBonus());
            }
        }
        public void StopAll()
        {

        }
        public void DestroyAll()
        {
            gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < gameObjects.Length; ++i)
            {
                Destroy(gameObjects[i]);
            }
            player.ScoreCoin(1000);
        }
        IEnumerator timeBonus()
        {
            yield return new WaitForSeconds(1f);
            Debug.LogWarning(" o speed");
            player.Speed(0f);
            actBonus = false;
        }
        #endregion
    }
}