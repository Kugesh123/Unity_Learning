using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] InputAction movement;
    [SerializeField] InputAction rotation;
    Rigidbody rb;
    [SerializeField] float speed = 10f;
    [SerializeField] float rotationSpeed = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        movement.Enable();
        rotation.Enable();
    }

    private void FixedUpdate()
    {
        MovementInput();
        RotationInput();
    }

    private void MovementInput()
    {
        if (movement.IsPressed())
        {
            rb.AddRelativeForce(Vector3.up * speed * Time.fixedDeltaTime);
        }
    }

    private void RotationInput()
    {
        float rotationInput = rotation.ReadValue<float>();
        //Debug.Log("My rotation value is : " + rotationInput);

        if (rotationInput < 0)
        {
            ApplyRotation(rotationSpeed);
        }

        else if (rotationInput > 0)
        {
            ApplyRotation(-rotationSpeed);
        }
    }

    private void ApplyRotation(float rotateThisFrame)
    {
        transform.Rotate(Vector3.forward * rotateThisFrame * Time.deltaTime);
    }
}
