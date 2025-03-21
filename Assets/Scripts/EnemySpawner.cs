using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; //���ʹ�������
    public Transform player; //�÷��̾���ġ
    public float spawnDistance = 10f; //�������Ÿ�
    public float spawnInterval = 3f; //�������ֱ�

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f , spawnInterval);  
    }

    void SpawnEnemy()
    {
        Vector3 spawnPos = player.position + Vector3.forward * spawnDistance;
        Instantiate(enemyPrefab,spawnPos,Quaternion.identity);
        
    }

    

}
