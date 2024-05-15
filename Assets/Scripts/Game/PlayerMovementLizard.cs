using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementLizard : MonoBehaviour
{

public float speed;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Debug.Log($"Horizontal input: {horizontal}, Vertical input: {vertical}");

        Vector3 movementDirection = new Vector3(horizontal, 0, vertical);
        movementDirection.Normalize();

        transform.position += movementDirection * speed * Time.deltaTime;
    }
}
