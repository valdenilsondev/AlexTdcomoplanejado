using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fecharCena : MonoBehaviour
{
    public void CasaCoberta()
    {
        SceneManager.LoadScene("ArqCasaExterno");
    }
    
    public void CasaDescoberta()
    {
        SceneManager.LoadScene("ArqCasaInterno");
    }

    public void SairAplicativo()
    {
        Application.Quit();
    }
}
