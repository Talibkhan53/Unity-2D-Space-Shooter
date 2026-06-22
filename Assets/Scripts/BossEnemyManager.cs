using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Transactions;
using UnityEngine;

public class BossEnemyManager : MonoBehaviour {
    [SerializeField] GameObject Boss;

    [SerializeField] GameObject leftMissle;
    [SerializeField] Transform leftMisslePosition;

    [SerializeField] GameObject rightMissile;
    [SerializeField] Transform rightmissileposition;

    [SerializeField] GameObject middleMissile;
    [SerializeField] Transform middleMissilePosition;

    [SerializeField] Transform playerPos;

    private Score score;
    private bool canWork = false;
    private float spawnTime = 3f;
    private int random;

    private void Start() {
        Boss.SetActive(false);
        score = FindObjectOfType<Score>();
    }


    private void Update() {
        if (canWork) {
            
            TimeCalculate();
            if (spawnTime <= 0) {
                RandomAttack();
                spawnTime = 3f;
                switch (random) {
                    case 0:
                        SingleAttack();
                        break;
                    case 1:
                        FlankAttack();
                        break;
                }
            }
        
        }
        if (score.score >= 20f) { Boss.SetActive(true);  canWork = true; }
    }

        void EnemyShootMiddleMissile() {
            GameObject missile = Instantiate(leftMissle, leftMisslePosition.position, Quaternion.identity);
                Destroy(missile, 5f);
        }

        void TimeCalculate() {
            spawnTime -= Time.deltaTime;
            
        }
        void FlankAttack() {
            GameObject missile1 =   Instantiate(leftMissle, leftMisslePosition.position, Quaternion.identity);
            GameObject missile2 =   Instantiate(rightMissile, rightmissileposition.position, Quaternion.identity);
            Vector2 dir = playerPos.position - missile1.transform.position;
            missile1.GetComponent<EnemyMissileMover>().SetDirection(dir);
            Vector2 dir1 = playerPos.position - missile2.transform.position;
            missile2.GetComponent<EnemyMissileMover>().SetDirection(dir1);
            Destroy(missile1,5f);
            Destroy(missile2, 5f);
    }

        void SingleAttack() {
        Debug.Log("Single Attack Called");

            GameObject missile =  Instantiate(leftMissle, leftMisslePosition.position, Quaternion.identity);
            Vector2 dir = playerPos.position - missile.transform.position;
            missile.GetComponent<EnemyMissileMover>().SetDirection(dir);
        Destroy(missile, 5f);
    }

        void RandomAttack() {
            random = Random.Range(0, 2);
        }

    }

