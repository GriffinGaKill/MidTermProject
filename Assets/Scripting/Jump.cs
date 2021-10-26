using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 1;
    public float maxForce = 10;
    public Rigidbody reggiebody;

    private float accumulatedForce = 0;
    public float m_Speed = 5f;

    private void Start()
    {
        //Fetches the rigidbody from the game object.
        reggiebody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //Store User input as a movement vector
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Apply the movement vector to the current position, which is multiplied by deltaTime and speed for a smooth MovePosition
        reggiebody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);

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
