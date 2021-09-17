using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float speedH, speedV, movementSpeed;
    private float yaw, pitch;

    private CharacterController avatar;

    // Start is called before the first frame update
    void Start()
    {
        speedH = 0.5f;
        speedV = 0.5f;
        movementSpeed = 2.0f;

        avatar = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraRotation();
        cameraMovement();
    }

    void cameraRotation()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch += speedV * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(-pitch, yaw, 0);
        }
    }

    void cameraMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            avatar.Move(Time.deltaTime * movementSpeed * transform.forward);
        }

        if (Input.GetKey(KeyCode.S))
        {
            avatar.Move(Time.deltaTime * movementSpeed * -transform.forward);
        }

        if (Input.GetKey(KeyCode.A))
        {
            avatar.Move(Time.deltaTime * movementSpeed * -transform.right);
        }

        if (Input.GetKey(KeyCode.D))
        {
            avatar.Move(Time.deltaTime * movementSpeed * transform.right);
        }
    }
}
