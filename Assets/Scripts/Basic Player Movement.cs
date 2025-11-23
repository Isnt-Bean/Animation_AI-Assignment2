using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour
{
    //https://medium.com/@fulton_shaun/character-movement-in-unity-3-ways-to-do-it-b10c6fd1a909 
    public float moveSpeed = 5f;
    public float gravity = -9.81f;
    public float jumpHeight = 1.5f;
    public float turnSpeed = 100f;

    private CharacterController controller;
    private Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0f, moveZ);
        controller.Move(move * moveSpeed * Time.deltaTime);
        
     
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;  
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        
        
        
        
        //https://www.youtube.com/watch?v=4J0tmIOwxOA
        float movementAmount = Mathf.Abs(moveX) + Mathf.Abs(moveZ);
        
        var movementInput = (new Vector3(moveX, 0, moveZ)).normalized;

        if (movementAmount > 0)
        {
            transform.rotation = Quaternion.LookRotation(movementInput);
        }
        
    }

}