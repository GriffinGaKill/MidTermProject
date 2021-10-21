using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject deathParticles;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 otherPosition = other.transform.position;

        Instantiate(deathParticles, otherPosition, Quaternion.identity);

        Destroy(other.gameObject);
    }
}
