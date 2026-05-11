using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState currentState;

    public GameObject pausePanel;
    public GameObject gameOverPanel;

    void Awake()
    {
        if(Instance == null)
        {
        Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        currentState = GameState.Playing;

        pausePanel.SetActive(false);
        gameOverPanel.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        currentState = GameState.Paused;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
        currentState = GameState.GameOver;
        Debug.Log("Game Over");
    }

    internal void SetState(GameState mainMenu)
    {
        throw new NotImplementedException();
    }
}