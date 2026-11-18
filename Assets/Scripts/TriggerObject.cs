using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    [SerializeField] GameObject boulder;

    void Awake()
    {
        boulder.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            boulder.SetActive(true);
            Destroy(boulder, 6f);
        }
    }
}
