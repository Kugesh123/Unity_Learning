
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] float moveSpeed = 5f;

    [Header("Mouse Settings")]
    [SerializeField] float mouseSensitivity = 2f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        RotatePlayer();
        PlayerMovement();
    }

    // Rotate the player horizontally using mouse X
    void RotatePlayer()
    {
        float mouseX = Input.GetAxis("Mouse X");

        float rotationAmount =
            mouseX * mouseSensitivity;

        transform.Rotate(
            0f,
            rotationAmount,
            0f,
            Space.World
        );
    }

    // Move the player in its facing direction
    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection =
            transform.forward * vertical +
            transform.right * horizontal;

        // Prevent faster diagonal movement
        moveDirection = Vector3.ClampMagnitude(
            moveDirection,
            1f
        );

        transform.position +=
            moveDirection * moveSpeed * Time.deltaTime;
    }
}
