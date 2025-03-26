using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public float attackPower = 50f; // 공격력
    public float attackInterval = 1.5f; // 공격 주기
    public bool isFighting = false;

    private Health playerHealth;
    private Health enemyHealth;
    private PlayerMove playerMove;

    private void Start()
    {
        playerMove = GetComponent<PlayerMove>();
        playerHealth = GetComponent<Health>(); // 플레이어 자신의 체력 가져오기
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && !isFighting)
        {
            isFighting = true;
            enemyHealth = other.GetComponent<Health>();

            Debug.Log("전투 시작!");
            InvokeRepeating("AttackEnemy", 0f, attackInterval);
        }
    }

    void AttackEnemy()
    {
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(attackPower);

            if (enemyHealth.currentHealth <= 0)
            {
                EndBattle();
            }
        }
    }

    void EndBattle()
    {        
        isFighting = false;
        playerMove.isFighting = false;
        CancelInvoke("AttackEnemy");
    }
}
