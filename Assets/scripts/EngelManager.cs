using UnityEngine;

public class EngelManager : MonoBehaviour
{
    [SerializeField] private int DamageAmount = 20;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<HealthController>().Ondamage(DamageAmount);
        }
    }
    
}
