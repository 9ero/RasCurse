using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaneHelper : MonoBehaviour
{
    public string EscenaPortada;
    public string EscenaJuego;
   
    public void SeguirJuego()
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
}
