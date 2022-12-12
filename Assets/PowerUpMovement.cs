using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMovement : MonoBehaviour
{
    private Vector3 movementVelocity;
    // Start is called before the first frame update
    void Start()
    {
        movementVelocity = Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90f * Time.deltaTime, 0, Space.World);
        transform.position += movementVelocity * Time.deltaTime;
        if (transform.position.y >= 2.5)
        {
            movementVelocity = Vector3.down;
        } 
        else if (transform.position.y <= 1.5)
        {
            movementVelocity = Vector3.up;
        }
    }
}
