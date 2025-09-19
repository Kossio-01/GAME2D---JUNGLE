using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    public TMPro.TextMeshProUGUI TextApple;
    public TMPro.TextMeshProUGUI TextBanana;
    private void Update()
    {
        if (GameManager.instance != null)
        {
           int apple = GameManager.instance.ScoreApple;
           int banana = GameManager.instance.ScoreBanana;
           TextApple.text = apple.ToString();
           TextBanana.text = banana.ToString();
        }
    }
    public void LoaderSceneM(string NameScene)
    {
        SceneManager.LoadScene(NameScene);
    }
}