using UnityEngine;

public class GameEndTrigger : MonoBehaviour
{
    [SerializeField] GameObject gameEndPanel;

    void Awake()
    {
        //boulder.SetActive(false);
        gameEndPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameEndPanel.SetActive(true);
        }
    }
}
