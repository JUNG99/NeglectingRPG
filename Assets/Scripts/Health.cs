using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f; //�ִ�ü��
    public float currentHealth; //����ü��

    private void Start()
    {
        currentHealth = maxHealth;
            
    }

    public void  TakeDamage(float damage)
    {
        currentHealth -= +damage;
        Debug.Log(gameObject.name + "ü��" + currentHealth);

        if (currentHealth < 0)
        {
            Die();
        }

    }

    void Die()
    {
        Debug.Log(gameObject.name + "���");
        Destroy(gameObject); //���� ��� ����
    }
    

}
