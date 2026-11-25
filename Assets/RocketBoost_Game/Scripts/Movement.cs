using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] InputAction movement;
    Rigidbody rb;
    [SerializeField] float speed = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        movement.Enable();
    }

    private void FixedUpdate()
    {
        if (movement.IsPressed())
        {
            //Debug.Log("Movement input is pressed.");
            rb.AddRelativeForce(Vector3.up * speed * Time.fixedDeltaTime);
        }
    }
}
