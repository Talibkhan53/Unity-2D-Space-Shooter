using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    private float speed = 6f;

    private void Update() {
        transform.Translate(new Vector2(speed * Time.deltaTime,0f));

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Border")) {
            speed *= -1;
        }
    }
}
