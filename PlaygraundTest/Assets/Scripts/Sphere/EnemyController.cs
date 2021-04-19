using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 11.0f;
    public GameObject player;
    public List<Enemy> enemyList;

    void Update()
    {
        foreach(var enemy in enemyList)
        {
            enemy.Go(player);
        }
    }

    public void RemoveEnemy(GameObject enemy)
    {
        var enemyScript = enemy.GetComponent<Enemy>();
        enemyList.Remove(enemyScript);
        enemyScript.Die();
    }
}
