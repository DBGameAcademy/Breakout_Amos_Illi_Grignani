using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject GameOverPannel;
    public Text ScoreText;
    public List<GameObject> LifeIcons = new List<GameObject>();
    public GameObject StartGamePannel;
    public GameObject PauseGamePannel;

    private void Start()
    {
        HidePausePannel();
        HideGameOver();
        ShowStartGamePannel();

    }

    public void UpdateScoreText(int _value)
    {
        ScoreText.text = _value.ToString();
    }

    public void UpdateLives(int _value)
    {
        for (int i = LifeIcons.Count - 1; i >= 0; i--)
        {
            LifeIcons[i].SetActive(_value >= i);
        }
    }

    public void ShowGameOver()
    {
        GameOverPannel.SetActive(true);
    }
    public void HideGameOver()
    {
        GameOverPannel.SetActive(false);
    }
    public void ShowStartGamePannel()
    {
        StartGamePannel.SetActive(true);
    }
    public void HideStartGamePannel()
    {
        StartGamePannel.SetActive(false);
    }
    public void ShowPausePannel()
    {
        PauseGamePannel.SetActive(true);
    }
    public void HidePausePannel()
    {
        PauseGamePannel.SetActive(false);
    }

}
