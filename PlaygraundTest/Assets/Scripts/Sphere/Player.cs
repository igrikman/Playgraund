using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Healtbar healthbar;
    public int score = 0;
    public TextMeshProUGUI indicator;

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

    void Update()
    {
      
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