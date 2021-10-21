using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 1;
    public float maxForce = 10;
    public Rigidbody reggiebody;

    private float accumulatedForce = 0;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            accumulatedForce = 0;
        }
        else if (Input.GetButton("Jump"))
        {
            accumulatedForce += jumpForce * Time.deltaTime;

            if (accumulatedForce > maxForce)
            {
                accumulatedForce = maxForce;
            }
        }
        else if (Input.GetButtonUp("Jump"))
        {
            reggiebody.AddForce(Vector3.up * jumpForce);
        }
    }
}
