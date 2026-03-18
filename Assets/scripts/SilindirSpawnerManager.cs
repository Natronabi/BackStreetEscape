using System.Collections;
using UnityEngine;

public class SilindirSpawnerManager : MonoBehaviour
{
   public GameObject objePrefab; // spawn edilecek nesne
   public float spawnDelay =  2f;
   public float yokEtmeSuresi = 6f;
    private void Start()
    {
      StartCoroutine(SpawnRoutine());  
    } 
    IEnumerator SpawnRoutine ()
    {
        while (true)
        {
            SpawnObje();
            yield return new WaitForSeconds(spawnDelay);
        }
    }
    void SpawnObje()
    {
            GameObject yeniSilindir = Instantiate(objePrefab ,transform.position, Quaternion.identity);
            Destroy (yeniSilindir, yokEtmeSuresi);
    }
}
