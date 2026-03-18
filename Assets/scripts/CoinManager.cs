using UnityEngine;
using DG.Tweening; // DOTween kütüphanesi için

public class CoinManager : MonoBehaviour
{
    RotateController rotate;
    [SerializeField] int puanMiktari = 5;

    // Dönme hızı (derece/saniye)
    public float rotationSpeed = 100f;

    // Yukarı-aşağı hareket için
    public float bobAmplitude = 0.5f; // Hareket yüksekliği
    public float bobFrequency = 2f;   // Hareket hızı
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<HealthController>().PuanArttir(puanMiktari);
            Destroy(gameObject);
        }
    }

    private Vector3 originalPosition;

    void Start()
    {
        // Orijinal pozisyonu kaydet
        originalPosition = transform.position;

        // DOTween ile yukarı-aşağı hareket (sonsuz döngü)
        transform.DOMoveY(originalPosition.y + bobAmplitude, 1f / bobFrequency)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.InOutSine);
    }

    void Update()
    {
        // Sürekli dönme
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
