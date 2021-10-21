using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public float turningSpeed;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        Vector3 tempR = this.transform.localEulerAngles;
        tempR.y += turningSpeed * horizontal * Time.deltaTime;


        controller.Move(this.transform.forward * speed * forward * Time.deltaTime);

        this.transform.localEulerAngles = tempR;
    }
}
