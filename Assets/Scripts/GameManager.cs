using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Init();
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private const string hightScoreKey = "HightScore";

    public int HightScore
    {
        get
        {
            return PlayerPrefs.GetInt(hightScoreKey, 0);
        }
        set
        {
            PlayerPrefs.SetInt(hightScoreKey, value);
        }
    }

    public int CurrentScore { get; set; }
    public bool IsInitialized { get; set; }

    private void Init()
    {
        CurrentScore = 0;
        IsInitialized = false;
    }

    private const string MainMenu = "MainMenu";
    private const string Gameplay = "Gameplay";

    public void GoToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(MainMenu);
    }
    public void GoToGamplay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Gameplay);
    }

}
