using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; //에너미프리팹
    public Transform player; //플레이어위치
    public float spawnDistance = 10f; //적생성거리
    public float spawnInterval = 3f; //적생성주기

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
