using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //GetComponent<Renderer>().material.color = Color.red;
        if (other.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material.color = Color.blueViolet;
            gameObject.tag = "Hit";
        }
    }
}
