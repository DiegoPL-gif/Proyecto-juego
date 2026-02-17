using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float     moveSpeed = 5f;
    private Rigidbody2D pb;
    private Vector2   moveInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        pb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        pb.linearVelocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
