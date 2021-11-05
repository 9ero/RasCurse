using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortadaHelper : MonoBehaviour
{
    public string EscenaJuego;
    public string EscenaCreditos;

    public void IniciarJuego()
    {
        try
        {
            GameManager.instancia.CambiarEscena(EscenaJuego);
        }
        catch (System.Exception ex)
        {
            Debug.Log("Se te olvido poner el Game en la escena");
        }
    }

    public void MostrarCreditos()
    {
        try
        {
            GameManager.instancia.CambiarEscena(EscenaCreditos);
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

