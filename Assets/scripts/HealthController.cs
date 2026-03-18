using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int MaxHealth = 100;
    public int toplamPuan = 0;
    public int CurrentHealth;
    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void Ondamage(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            gameObject.SetActive(false);
            Debug.Log("Karakter öldü!");
            // Karakterin ölme işlemlerini burada gerçekleştirin
        }
    }
    public void PuanArttir(int puanMiktari)
    {
        toplamPuan += puanMiktari;
    }
}
    
