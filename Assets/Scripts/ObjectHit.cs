using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //GetComponent<Renderer>().material.color = Color.red;
        //Debug.Log("collision detected : " + gameObject.name);

        if (gameObject.name == "Obstacle_1")
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        else if (gameObject.name == "Obstacle_2")
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
