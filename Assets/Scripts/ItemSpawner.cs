using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public LayerMask groundLayer;
    public int itemCount = 10;
    public float spawnRadius = 0.5f;

    void Start()
    {
        SpawnItems();
    }

    public void SpawnItems()
    {
        for (int i = 0; i < itemCount; i++)
        {
            Vector2 spawnPos = GetValidSpawnPosition();
            if (spawnPos != Vector2.zero)
            {
                int prefabIndex = Random.Range(0, itemPrefabs.Length);
                Instantiate(itemPrefabs[prefabIndex], spawnPos, Quaternion.identity);
            }
        }
    }

    Vector2 GetValidSpawnPosition()
    {
        for (int attempt = 0; attempt < 20; attempt++)
        {
            float x = Random.Range(-8f, 8f);
            float y = Random.Range(-4f, 4f);
            Vector2 origin = new Vector2(x, y + 5f);

            RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down, 10f, groundLayer);
            if (hit.collider != null)
            {
                Vector2 groundPos = hit.point;
                if (!Physics2D.OverlapCircle(groundPos, spawnRadius))
                {
                    return groundPos;
                }
            }
        }
        return Vector2.zero;
    }
}