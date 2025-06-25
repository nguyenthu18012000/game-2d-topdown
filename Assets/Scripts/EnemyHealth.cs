using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int startingHelth = 3;

    private int currentHealth;

    private void Start()
    {
        currentHealth = startingHelth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("Enemy took damage: " + damageAmount + ", Current Health: " + currentHealth);
        DetechDeath();
        //if (currentHealth <= 0)
        //{
        //    Die();
        //}
    }

    private void DetechDeath()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
