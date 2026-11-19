using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    Renderer myMeshRenderer;
    Rigidbody myRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<Renderer>();
        myMeshRenderer.enabled = false;

        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("The time elapsed since the playmode started is : " + Time.time);
        if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
            Debug.Log("The time elapsed");
        }
    }
}
