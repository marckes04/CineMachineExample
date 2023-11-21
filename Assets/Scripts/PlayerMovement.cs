using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 180f;

    private void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);

        // Player rotation
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(0f, mouseX, 0f) * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotation);
    }

}
