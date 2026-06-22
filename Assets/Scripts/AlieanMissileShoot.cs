using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlieanMissileShoot : MonoBehaviour
{
    [SerializeField] Transform missilePosition;
    [SerializeField] GameObject missile;

    bool canFire = true;

    private void Update() {
        if (canFire) {
            Shoot();
            canFire = false;
        }
    }

    void Shoot() {
        GameObject gm = Instantiate(missile, missilePosition.position,Quaternion.identity);
        Destroy(gm,5f);
    }


}
