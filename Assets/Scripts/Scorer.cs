using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //score ++;
        score = score + 1;
        Debug.Log("You have collided with something this many times : " + score);
    }
}
