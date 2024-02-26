using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            GetComponent<Rigidbody>().velocity = new Vector3 (0,5,0);
        }

         if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = -transform.forward * moveSpeed;
        }   
    }
}
