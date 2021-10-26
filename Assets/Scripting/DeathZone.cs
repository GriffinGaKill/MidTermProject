using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public GameObject deathParticles;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 otherPosition = other.transform.position;

        Instantiate(deathParticles, otherPosition, Quaternion.identity);

        Destroy(other.gameObject);

        SceneManager.LoadScene("Game Over");
    }

}
