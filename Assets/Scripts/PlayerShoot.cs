using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject missile;
    [SerializeField] private Transform missileSpawnPosition;
    private float destryTime = 5f;
    private void Update() {
        Shoot();
    }
    private void Shoot() {
        if (Input.GetKeyDown(KeyCode.Space)) {
          GameObject missileObject =   Instantiate(missile, missileSpawnPosition.position,Quaternion.identity);
            Destroy(missileObject, destryTime);

        }
    }
}
