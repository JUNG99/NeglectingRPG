using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Battle : MonoBehaviour
{
    public float attackPower = 20f; //공격력
    public float attackInterval = 1.5f; //공격주기
    public bool isFighting = false;
    private Health playerHealth;
    private Health enemyHealth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && !isFighting)
        {
            isFighting = true;
            enemyHealth = other.GetComponent<Health>();
            playerHealth = other.GetComponent<Health>();

            InvokeRepeating("AttackEnemy", 0f, attackInterval);
        }
    }

    void AttackEnemy()
    {
        if(enemyHealth != null)
        {
            enemyHealth.TakeDamage(attackPower);
            if(enemyHealth == null )
            {
                isFighting = false;
                CancelInvoke("AttackEney");
            }
        }
    }
        
}
