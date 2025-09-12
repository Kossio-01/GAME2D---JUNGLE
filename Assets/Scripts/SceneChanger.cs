using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Método para cambiar a Escena2 por nombre
    public void LoadEscena2()
    {
        SceneManager.LoadScene("Escena2");
    }
    
    // Método para cambiar a Escena1 por nombre
    public void LoadEscena1()
    {
        SceneManager.LoadScene("Escena1");
    }
    
    // Método para cambiar por índice (ejemplo)
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}