using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    
    public float speed = 5.0f;
    public float rotationSpeed;
    public float verticalInput;

    
    
    

    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();

    }
   
    public InputAction moveAction;
    
    private Vector2 moveInput;
   
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * rotationSpeed);

        transform.Translate(Vector3.up * Time.deltaTime * verticalInput * speed);

    }
}
