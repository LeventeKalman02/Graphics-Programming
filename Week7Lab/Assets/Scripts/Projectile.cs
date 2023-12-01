using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //declaring rigidbody
    public Rigidbody projectile;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            //this creates the projectile clone every time the key is pressed
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            clone.velocity = transform.forward * 100;

        }
    }
}
