using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorObjetos : MonoBehaviour
{
    public int objetosRecolectados = 0;
    public TextMeshProUGUI textoContador;

    void Start()
    {
        ActualizarTexto();
    }

    public void SumarObjeto()
    {
        objetosRecolectados++;
        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        textoContador.text = "Objetos: " + objetosRecolectados;
    }
}