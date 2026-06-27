using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public GameObject panelWin;
    public GameObject panelGameOver;

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateTimer(float timer)
    {
        int tiempo = Mathf.CeilToInt(timer);

        if (tiempo < 0)
        {
            tiempo = 0;
        }

        timerText.text = "00:" + tiempo.ToString("00");
    }

    public void MostrarPantallaWin()
    {
        panelWin.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        panelGameOver.SetActive(true);
    }
}