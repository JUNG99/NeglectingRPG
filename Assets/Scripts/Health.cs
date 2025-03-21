using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f; //최대체력
    public float currentHealth; //현재체럭

    private void Start()
    {
        currentHealth = maxHealth;
            
    }

    public void  TakeDamage(float damage)
    {
        currentHealth -= +damage;
        Debug.Log(gameObject.name + "체력" + currentHealth);

        if (currentHealth < 0)
        {
            Die();
        }

    }

    void Die()
    {
        Debug.Log(gameObject.name + "사망");
        Destroy(gameObject); //죽은 대상 제거
    }
    

}
