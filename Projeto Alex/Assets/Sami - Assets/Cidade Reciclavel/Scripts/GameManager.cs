using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private interacao interaction;

    public GameObject[] objetosIntarativos;

    public Transform posicaoInstanciar;

    public int num;
    void Start()
    {
        interaction = FindObjectOfType(typeof(interacao)) as interacao;
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction.isLixo == true)
        {
           
           // interaction.isLixo = false;
        }
       
    }
}
