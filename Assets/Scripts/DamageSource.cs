using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DamageSource : MonoBehaviour
{
     [SerializeField] private int damageAmount = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<EnemyHealth>())
        {
            EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>();
            enemyHealth.TakeDamage(damageAmount); // Assuming damage amount is 1
            Debug.Log("DamageSource: OnTriggerEnter2D: " + other.gameObject.name);
        }
    }
}
