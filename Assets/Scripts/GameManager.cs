using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    public UIManager uiManager;

    public bool juegoTerminado = false;

    void Awake()
    {
        Time.timeScale = 1;

        if (uiManager == null)
        {
            uiManager = FindObjectOfType<UIManager>();
        }
    }

    void Update()
    {
        if (juegoTerminado)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            return;
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
            uiManager.UpdateTimer(timer);
        }

        if (timer <= 0)
        {
            juegoTerminado = true;
            uiManager.MostrarPantallaGameOver();
            Time.timeScale = 0;
        }
    }
}