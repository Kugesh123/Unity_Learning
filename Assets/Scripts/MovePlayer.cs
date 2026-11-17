
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xValue, 0f, zValue);

        transform.Translate(
            movement * moveSpeed * Time.deltaTime,
            Space.Self
        );
    }
}
