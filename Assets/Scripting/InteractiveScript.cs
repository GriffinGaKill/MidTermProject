using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveScript : MonoBehaviour
{
    public GameObject topBody;
    public ParticleSystem blood;

    public AudioClip dieSound;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (topBody.activeInHierarchy)
        {
            topBody.SetActive(false);
            blood.Play();

            audioSource.PlayOneShot(dieSound);
        }

        SceneManager.LoadScene("Win");
    }
}
