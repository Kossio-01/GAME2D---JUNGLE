using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagTrigger : MonoBehaviour
{
    public string nextSceneName = "Scene2"; // Set this in the Inspector or use build index

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}