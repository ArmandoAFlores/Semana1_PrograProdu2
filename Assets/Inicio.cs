using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{
    public GameObject prueba;
    public void StartG()
    {
        SceneManager.LoadScene("Escena1");
    }
    public void QuitGame()
    {
        Debug.Log("Se salió");
        Application.Quit();
    }
}
