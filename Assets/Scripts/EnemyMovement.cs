using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float enemySpeed = 3f;
    private Score score;


    private void Start() {
        score = FindObjectOfType<Score>();
    }

    void Update()
    {
        transform.Translate( new Vector2 (0, -enemySpeed * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Missile")) {
            score.AddScore();
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Destroy")) {
            Destroy(gameObject);
        }
    }
    }
