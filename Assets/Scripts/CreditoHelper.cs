using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditoHelper : MonoBehaviour
{

    public string EscenaPortada;

    public void VolverPortada()
    {
        try
        {
            GameManager.instancia.CambiarEscena(EscenaPortada);
        }
        catch (System.Exception ex)
        {
            Debug.Log("Se te olvido poner el Game en la escena");
        }
    }

    public void Salir()
    {
        try
        {
            GameManager.instancia.Salir();
        }
        catch (System.Exception ex)
        {
            Debug.Log("Se te olvido poner el Game en la escena");
        }
    }
}
