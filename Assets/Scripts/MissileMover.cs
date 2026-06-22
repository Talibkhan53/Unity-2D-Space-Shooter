using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMover : MonoBehaviour
{
    private float missileSpeed = 20f;
    private void Update() {
        transform.Translate(Vector3.up  * missileSpeed*Time.deltaTime);
    }

}
