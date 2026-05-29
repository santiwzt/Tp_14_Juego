using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoRecolectable : MonoBehaviour
{
    public ContadorObjetos contador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Se ha recolectado el lápiz ");

            contador.SumarObjeto();
            Destroy(gameObject);
        }
    }
}

