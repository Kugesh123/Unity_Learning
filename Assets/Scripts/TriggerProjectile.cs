using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile_1;
    [SerializeField] GameObject projectile_2;
    [SerializeField] GameObject projectile_3;
    [SerializeField] GameObject projectile_4;

    void Start()
    {
        projectile_1.SetActive(false);
        projectile_2.SetActive(false);
        projectile_3.SetActive(false);
        projectile_4.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectile_1.SetActive(true);
            projectile_2.SetActive(true);
            projectile_3.SetActive(true);
            projectile_4.SetActive(true);
        }
    }
}
