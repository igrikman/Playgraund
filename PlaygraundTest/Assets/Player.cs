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

   
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
        
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
}
