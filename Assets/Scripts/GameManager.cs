using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton


    private static GameManager _instancia;
    public static GameManager instancia { get { return _instancia; } }

    public void Awake()
    {

        if (_instancia == null)
        {
            _instancia = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    public void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void SubirNivel()
    {

        if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("TBC"))
        {
            CambiarEscena("Level2");
        }else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
        {
            CambiarEscena("level3");
        }else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3"))
        {
            CambiarEscena("level4");
        }
        else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level4"))
        {
            CambiarEscena("level5");
        }
        else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level5"))
        {
            CambiarEscena("Gane");
        }
    }
    

    public void Salir()
    {
        Application.Quit();
    }
}
