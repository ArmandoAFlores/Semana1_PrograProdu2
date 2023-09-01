using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void StartG()
    {
        SceneManager.LoadScene("Hola -.-");
    }
    public void QuitGame()
    {
        Debug.Log("Funciona");
        Application.Quit();
    }
}

