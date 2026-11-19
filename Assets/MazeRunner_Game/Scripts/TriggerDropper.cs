using UnityEngine;

public class TriggerDropper : MonoBehaviour
{
    [SerializeField] GameObject dropper;

    void Awake()
    {
        dropper.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            dropper.SetActive(true);
        }
    }
}
