using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    public int score = 0;
    public int puntajeMaximo = 1;

    private UIManager uiManager;
    private GameManager gameManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            score++;
            uiManager.UpdateScore(score);

            Debug.Log("Se ha recolectado: " + other.gameObject.name);

            Destroy(other.gameObject);

            if (score >= puntajeMaximo)
            {
                gameManager.juegoTerminado = true;
                uiManager.MostrarPantallaWin();
                Time.timeScale = 0;
            }
        }
    }
}