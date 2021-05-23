using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //УДАЛИТЬ 
    [SerializeField] private float speed = 11.0f;
    [SerializeField] private GameObject player;
    [SerializeField] private List<Enemy> enemyList;

    //void Update()
    //{
    //    foreach(var enemy in enemyList)
    //    {
    //        enemy.Go(player);
    //    }
    //}

    public void RemoveEnemy(GameObject enemy)
    {

        var enemyScript = enemy.GetComponent<Enemy>();
        enemyList.Remove(enemyScript);
        enemyScript.Die();
    }
}
