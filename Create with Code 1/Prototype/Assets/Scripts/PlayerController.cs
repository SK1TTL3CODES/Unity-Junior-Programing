using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable the moveAction so it starts reading input
        moveAction.Enable();
    }
    //Movement tuning (editable in inspector)
    public float speed = 5.0f;
    public float turnSpeed;

    // Input System action exposed in Inspector for binding (WASD/Arrow keys)
    public InputAction moveAction;
    // Current input value (x = left/right, y = forward/back), kept private for internal use
    private Vector2 moveInput;

    // Update is called once per frame
    void Update()
    {
        // Read the 2D vector from the moveAction (x: horizontal, y: vertical)
        moveInput = moveAction.ReadValue<Vector2>();
        //We'll move the Vehicle forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        // Rotate around local Y (yaw) using the x component
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
     
    }
}
