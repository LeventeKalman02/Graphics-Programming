using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class CubeCloner : MonoBehaviour
{
    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //statement to spawn a new cube at set coordinates every time the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");

            //spawns the new cube and tet location
            Instantiate(Cube, new Vector3(0, 1, 0), Quaternion.identity);
            
        }
    }
}
