using UnityEngine;
public class MovePlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInformation();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovemet();
    }

    void PrintInformation()
    {
        //Debug.Log("The game starts");
        //Debug.Log("The player is moving");
        //Debug.Log("it will be moving in the x and z axis");
    }

    void PlayerMovemet()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(xValue * moveSpeed, yValue, zValue * moveSpeed);
    }
}
