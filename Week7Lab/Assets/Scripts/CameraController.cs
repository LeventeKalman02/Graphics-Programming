using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //setting camera to the player
    public GameObject player;
    private Vector3 offset;

    //looking around with mouse
    Vector2 rotation = Vector2.zero;
    public float speed = 3; //the sensitivity

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

        //camera follows the movement of the mouse
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        transform.eulerAngles = (Vector2)rotation * speed;
    }
}
