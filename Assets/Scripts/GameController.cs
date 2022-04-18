using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int Lives = 3;
    public int InitialLives = 3;
    public Ball Ball;
    public int Score = 0;
    public Vector3 BallResetPosition;
    public GameObject ExplosionPrefab;
    public UIController UIController;
    public AudioController AudioController;
    public BlockController BlockController;
    private bool isPlaying = false;
    public bool IsPlaying { get { return isPlaying; } }
    private bool isPaused = false;
    public bool IsPaused { get { return isPaused; } }

    public void Start()
    {
        UIController.UpdateScoreText(Score);
        UIController.UpdateLives(Lives);
        PauseGame();
    }

    private void Update()
    {
        if (!isPaused && Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        else if (isPaused && Input.anyKeyDown)
        {
            UnpauseGame();
        }
    }

    public void AdScore(int _value)
    {
        Score += _value;
        UIController.UpdateScoreText(Score);

    }

    public void BallLost()
    {
        // position
        Ball.transform.position = BallResetPosition;
        Vector3 currentVelocity = Ball.Velocity;
        currentVelocity.y = Mathf.Abs(currentVelocity.y);
        Ball.Velocity = currentVelocity;

        //life
        Lives--;
        UIController.UpdateLives(Lives);
        if (Lives < 0)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        UIController.ShowGameOver();
        isPlaying = false;
        PauseGame();
    }
    public void StartGame()
    {
        isPlaying = true;
        ResetGame();
        UnpauseGame();
    }
    private void ResetGame()
    {
        Lives = InitialLives;
        Score = 0;
        UIController.UpdateScoreText(Score);
        UIController.UpdateLives(Lives);
        UIController.HideStartGamePannel();
        UIController.HideGameOver();
        BlockController.ResetBlocks();
    }
    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;
        if (isPlaying)
        {
            UIController.ShowPausePannel();
        }
    }
    public void UnpauseGame()
    {
        isPaused=false;
        Time.timeScale = 1;
        UIController.HidePausePannel();

    }
    public void QuitGame()
    {
        isPlaying = false;
        PauseGame();
        UIController.HideGameOver();
        UIController.HidePausePannel();
        UIController.ShowStartGamePannel();
        Ball.transform.position = BallResetPosition;
    }
}
