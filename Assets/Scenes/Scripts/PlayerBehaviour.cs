using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // A reference to the RigidBody component
    private Rigidbody rb;
    // How fast the ball moves left/right
    public float dodgeSpeed = 5;
    // How fast the ball moves forward automatically
    public float rollSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        // Get access to our rigidbody component
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Check if we're moving to the side
        var horizontalSpeed = Input.GetAxis("Horizontal") * dodgeSpeed;
        rb.AddForce(horizontalSpeed, 0, rollSpeed);
        
    }
}
