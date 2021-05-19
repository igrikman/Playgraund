using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3;
    private int currentHealth;
    [SerializeField] private Healtbar healthbar;
    private int score = 0;
    [SerializeField] private TextMeshProUGUI indicator;
    [SerializeField] private EnemyController enemyController;

    private void OnCollisionEnter(Collision PlayerCol)
    {
        if (PlayerCol.gameObject.tag == "Enemy")
        {
            Debug.Log("Получил урон");
            TakeDamage(1);
            enemyController.RemoveEnemy(PlayerCol.gameObject);
        }
        else if (PlayerCol.gameObject.tag == "CoinTag")
        {
            Destroy(PlayerCol.gameObject, 0f);
            ScoreCoin(1);
        }
    }

    void ScoreCoin(int takecoin)
    {
        score += takecoin;
        indicator.text = score.ToString();
    }

    void Start()
    {
        indicator.text = score.ToString();
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
        if (currentHealth == 0)
        {
            Debug.LogError("Вы умерли");
            Destroy(gameObject, 0f);
        }
    }

  
}