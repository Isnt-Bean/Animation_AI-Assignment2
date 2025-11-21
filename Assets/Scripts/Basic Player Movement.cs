using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Get input values
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Movement direction
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        // Apply movement
        transform.Translate(direction * speed * Time.deltaTime);
    }
}