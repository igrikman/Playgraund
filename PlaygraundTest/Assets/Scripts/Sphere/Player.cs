using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Healtbar healthbar;

   
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }
    private void OnCollisionEnter(Collision PlayerCol)
    {
        if (PlayerCol.gameObject.tag == "Enemy")
        {
            Debug.Log("Получил урон");
            TakeDamage(1);
        }
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