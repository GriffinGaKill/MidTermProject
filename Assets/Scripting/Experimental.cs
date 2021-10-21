using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experimental : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public float maxForce = 10;
    public Rigidbody reggiebody;

    private float accumulatedForce = 0;

    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }

    public CharacterController controller;
    public float speed;
    public float turningSpeed;

    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

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

        Vector3 tempR = this.transform.localEulerAngles;
        tempR.y += turningSpeed * horizontal * Time.deltaTime;


        controller.Move(this.transform.forward * speed * forward * Time.deltaTime);

        this.transform.localEulerAngles = tempR;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
