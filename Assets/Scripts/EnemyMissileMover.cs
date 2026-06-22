using UnityEngine;

public class EnemyMissileMover : MonoBehaviour {
    [SerializeField] float speed = 20f;
    private Vector2 direction;
    private bool aimAtPlayer = false;

    public void SetDirection(Vector2 dir) {
        direction = dir.normalized;
        aimAtPlayer = true;
    }

    void Update() {
        if (aimAtPlayer) { 
            transform.position += (Vector3)(direction * speed * Time.deltaTime);
        }
        
        else
            transform.Translate(Vector3.down * speed * Time.deltaTime,Space.Self);
    }
}