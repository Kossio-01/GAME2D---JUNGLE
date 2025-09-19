using System;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    
    public enum ItemType
    
    {
        apple,
        banana
    }
    [Header("Opciones de items")]
    public ItemType type = ItemType.apple;
    public int itemvalue = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnTriggerEnter2D(Collider2D collision)
  {
      if (!collision.CompareTag("Player")) return;
      if (GameManager.instance == null)
      {
          Debug.LogError("GameManager instance is null!");
          return;
      }
      switch (type)
      {
          case ItemType.apple:
              GameManager.instance.TotalApple(itemvalue);
              break;
          case ItemType.banana:
              GameManager.instance.TotalBanana(itemvalue);
              break;
          default:
              throw new ArgumentOutOfRangeException();
      }
      Destroy(gameObject);
  }
}
