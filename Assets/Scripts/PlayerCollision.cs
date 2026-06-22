using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("EMissile")) {
            Object.FindAnyObjectByType<GameManager>().TriggerGameOver();
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy")) {
            Object.FindAnyObjectByType<GameManager>().TriggerGameOver();
            Destroy(gameObject);
        }
    }
    
}
