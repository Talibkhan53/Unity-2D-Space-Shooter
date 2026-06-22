using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    private float timeToSpawnEnemy = 2f;

    private void Update() {
        timeToSpawnEnemy -= Time.deltaTime;
        if(timeToSpawnEnemy <= 0) {
        SpawningEnemy();
        timeToSpawnEnemy = 2f;   
        }
    }
    private void SpawningEnemy() {

        float randomX = Random.Range(-10f, 10f);
        Instantiate(enemyPrefab, new Vector2(randomX,2.87f), Quaternion.identity);
    }
}
