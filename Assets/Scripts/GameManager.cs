using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}   
    private float globaltime;
    public float GlobalTime {get => globaltime; set => globaltime = value; }
    private int scoreapple = 0;
    public int ScoreApple
        {
    get { return scoreapple; }
    set { scoreapple = value; }
        }

private int scorebanana = 0;
    public int ScoreBanana
        {
    get { return scorebanana; }
    set { scorebanana = value; }
        }
    
    void Awake()
    {
        if (instance != null && instance != this)
        {
             Destroy(gameObject);
             return;
        }
        {
            instance = this; 
            DontDestroyOnLoad(gameObject);
        }
    }
    
    public void TotalApple(int apple)
    {
        scoreapple += apple;
    }
    public void TotalBanana(int banana)
    {
        scorebanana += banana;
    }
    
    public void TotalTime(float timescene)
    {
        globaltime += timescene;
    }

    void Start()
    {
        globaltime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
