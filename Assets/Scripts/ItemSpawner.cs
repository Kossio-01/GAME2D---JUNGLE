using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public Transform[] spawnPoints; 
    

    void Start()
    {
        System.Random rng = new System.Random();
        int[] indices = new int[spawnPoints.Length];
        for (int i = 0; i < indices.Length; i++) indices[i] = i;
        for (int i = indices.Length - 1; i > 0; i--)
        {
            int swap = rng.Next(i + 1);
            int temp = indices[i];
            indices[i] = indices[swap];
            indices[swap] = temp;
        }

        int itemTotal = Mathf.Min(itemPrefabs.Length, spawnPoints.Length);
        for (int i = 0; i < itemTotal; i++)
        {
            GameObject prefab = itemPrefabs[i % itemPrefabs.Length];
            Transform point = spawnPoints[indices[i]];
            Instantiate(prefab, point.position, Quaternion.identity);
        }
    }
}