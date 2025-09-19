using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerMinutes;
    public TextMeshProUGUI timerSeconds;
    public TextMeshProUGUI timerSeconds100;

    private float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 1 && !isRunning) // Scene 1
        {
            TimerStart();
        }
    }

    public void TimerStart()
    {
        if (!isRunning)
        {
            isRunning = true;
            startTime = Time.time - stopTime; // Continue from previous time
        }
    }

    public void TimerStop()
    {
        if (isRunning)
        {
            isRunning = false;
            stopTime = timerTime;
        }
    }

    public void TimerReset()
    {
        stopTime = 0;
        isRunning = false;
        timerMinutes.text = timerSeconds.text = timerSeconds100.text = "00";
    }

    void Update()
    {
        if (isRunning)
        {
            timerTime = Time.time - startTime;
            int minutesInt = (int)timerTime / 60;
            int secondsInt = (int)timerTime % 60;
            int seconds100Int = (int)((timerTime - (secondsInt + minutesInt * 60)) * 100);

            timerMinutes.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
            timerSeconds.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
            timerSeconds100.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
        }
    }
}
