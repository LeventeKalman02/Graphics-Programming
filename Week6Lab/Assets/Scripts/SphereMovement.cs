using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShpereMovement : MonoBehaviour
{
    //declaring rigidBody
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //gets the component "Rigid Body" from the current GameObject
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //This moves the ball upward when the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");

            //move the object upward
            transform.Translate(Vector3.up);
        }

        //Loops to add Force to Sphere to move it with the Arrow keys
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //impart a force moving the object to the right
            rb.AddForce(Vector3.right, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //impart a force moving the object to the left
            rb.AddForce(Vector3.left, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //impart a force moving the object to the up
            rb.AddForce(Vector3.forward, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //impart a force moving the object to the down
            rb.AddForce(Vector3.back, ForceMode.Force);
        }
    }
}
