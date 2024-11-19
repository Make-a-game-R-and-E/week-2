using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The speed of the player")]
    float speed = 5f;

    [SerializeField]
    [Tooltip("Input action for moving right")]
    InputAction moveRight = new InputAction("moveRight", type: InputActionType.Button, "<Keyboard>/d");

    [SerializeField]
    [Tooltip("Input action for moving left")]
    InputAction moveLeft = new InputAction("moveLeft", type: InputActionType.Button, "<Keyboard>/a");

    private float minX = -6.5f; // Minimum x boundary
    private float maxX = 25f;  // Maximum x boundary

    private void OnEnable()
    {
        moveRight.Enable();
        moveLeft.Enable();
    }

    private void OnDisable()
    {
        moveRight.Disable();
        moveLeft.Disable();
    }

    void Update()
    {
        Vector3 newPosition = transform.position;

        if (moveRight.IsPressed() && newPosition.x < maxX)
        {
            newPosition += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (moveLeft.IsPressed() && newPosition.x > minX)
        {
            newPosition += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }

        transform.position = newPosition;
    }
}
