using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class GameController : MonoBehaviour
    {
        private ManagerBonus manBonus;
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
            player.ScoreCoin(5);
            Destroy(enemy.gameObject, 2f);
            Bonus(enemy);
        }
        public void Bonus(EnemyRino enemy)
        {
            var bonusRandIndex = Random.Range(0, 100);

            if (bonusRandIndex >= 0 && bonusRandIndex < 35)
            {
                Score(enemy);
            }
            if (bonusRandIndex >= 36 && bonusRandIndex < 47)
            {
                Speed(enemy);
            }
            if (bonusRandIndex >= 47 && bonusRandIndex < 100)
            {
                Debug.LogWarning("Ни хуя");
            }
        }
        public ManagerBonus.Bonus mBonus;
        private void OnCollisionEnter(Collision BonusCol)
        {
            if (BonusCol.gameObject.tag == "Player")
            {
                Destroy(bonus.gameObject);
            }
        }

        public void Score(EnemyRino enemy)
        {
            var newBonus = Instantiate(bonus);
            newBonus.transform.position = enemy.transform.position;
            bonus = ManagerBonus.Bonus.Score;
            Debug.LogWarning("Score");
            
            if (manBonus== player)
            {
                player.ScoreCoin(100);
            }
        }
        public void Speed(EnemyRino enemy)
        {
            
            mBonus = ManagerBonus.Bonus.Speed;
            var newBonus = Instantiate(bonus);
            newBonus.transform.position = enemy.transform.position;
            Debug.LogWarning("Speed");
            if (manBonus == player)
            {
                player.Speed(6f);
            }
        }







    }
}