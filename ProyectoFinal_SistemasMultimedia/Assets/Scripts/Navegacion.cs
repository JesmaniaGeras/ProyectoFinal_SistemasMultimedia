using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    public void EscenaPlantilla1()
    {
        SceneManager.LoadScene("Programador1");
    }

    public void EscenaPlantilla2()
    {
        SceneManager.LoadScene("Programador2");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void EscenaProyectoImportanteV()
    {
        SceneManager.LoadScene("ProyectoImportanteV");
    }

    public void EscenaProyectoImportanteH()
    {
        SceneManager.LoadScene("ProyectoImportanteH");
    }

    public void RealidadAumentada()
    {
        SceneManager.LoadScene("RealidadAumentada");
    }

}
