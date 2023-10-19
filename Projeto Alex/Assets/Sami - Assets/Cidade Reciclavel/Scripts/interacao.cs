using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao : MonoBehaviour
{


    private bool isInteracao;
    public bool isLixo;
    public GameObject objetoLixo;
    public int valor;
    private GameManager _gameManager;

    private int limiteSuperior = 17;
    void Start()
    {
        _gameManager = FindObjectOfType(typeof(GameManager)) as GameManager;
    }

    // Update is called once per frame
    void Update()
    {
       if (isInteracao)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                isLixo = true;
            }
        }

        if (isLixo == true)
        {

            if(valor == 0)
            {
                _gameManager.objetosIntarativos[0].SetActive(true);
                for(int i = 1; i < limiteSuperior;i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 1)
            {
                _gameManager.objetosIntarativos[1].SetActive(true);
                _gameManager.objetosIntarativos[0].SetActive(false);

                for (int i = 2; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 2)
            {
                _gameManager.objetosIntarativos[2].SetActive(true);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);

                for (int i = 3; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 3)
            {
                _gameManager.objetosIntarativos[3].SetActive(true);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                for (int i = 4; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 4)
            {
                _gameManager.objetosIntarativos[4].SetActive(true);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);


                for (int i = 5; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 5)
            {
                _gameManager.objetosIntarativos[5].SetActive(true);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);

                for (int i = 6; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 6)
            {
                _gameManager.objetosIntarativos[6].SetActive(true);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);


                for (int i = 7; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 7)
            {
                _gameManager.objetosIntarativos[7].SetActive(true);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                for (int i = 8; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 8)
            {
                _gameManager.objetosIntarativos[8].SetActive(true);
                _gameManager.objetosIntarativos[7].SetActive(false);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                for (int i = 9; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 9)
            {
                _gameManager.objetosIntarativos[9].SetActive(true);
                _gameManager.objetosIntarativos[8].SetActive(false);
                _gameManager.objetosIntarativos[7].SetActive(false);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                for (int i = 10; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 10)
            {
                _gameManager.objetosIntarativos[10].SetActive(true);
                _gameManager.objetosIntarativos[9].SetActive(false);
                _gameManager.objetosIntarativos[8].SetActive(false);
                _gameManager.objetosIntarativos[7].SetActive(false);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                for (int i = 11; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 11)
            {
                _gameManager.objetosIntarativos[11].SetActive(true);
                _gameManager.objetosIntarativos[10].SetActive(false);
                _gameManager.objetosIntarativos[9].SetActive(false);
                _gameManager.objetosIntarativos[8].SetActive(false);
                _gameManager.objetosIntarativos[7].SetActive(false);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                for (int i = 12; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 12)
            {
                _gameManager.objetosIntarativos[12].SetActive(true);
                _gameManager.objetosIntarativos[11].SetActive(false);
                _gameManager.objetosIntarativos[10].SetActive(false);
                _gameManager.objetosIntarativos[9].SetActive(false);
                _gameManager.objetosIntarativos[8].SetActive(false);
                _gameManager.objetosIntarativos[7].SetActive(false);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                _gameManager.objetosIntarativos[13].SetActive(false);
                for (int i = 13; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }

            }
            if (valor == 13)
            {
                _gameManager.objetosIntarativos[13].SetActive(true);
                _gameManager.objetosIntarativos[12].SetActive(false);
                _gameManager.objetosIntarativos[11].SetActive(false);
                _gameManager.objetosIntarativos[10].SetActive(false);
                _gameManager.objetosIntarativos[9].SetActive(false);
                _gameManager.objetosIntarativos[8].SetActive(false);
                _gameManager.objetosIntarativos[7].SetActive(false);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                _gameManager.objetosIntarativos[13].SetActive(false);
                for (int i = 14; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }
            }
            if (valor == 14)
            {
                _gameManager.objetosIntarativos[14].SetActive(true);
                _gameManager.objetosIntarativos[13].SetActive(false);
                _gameManager.objetosIntarativos[12].SetActive(false);
                _gameManager.objetosIntarativos[11].SetActive(false);
                _gameManager.objetosIntarativos[10].SetActive(false);
                _gameManager.objetosIntarativos[9].SetActive(false);
                _gameManager.objetosIntarativos[8].SetActive(false);
                _gameManager.objetosIntarativos[7].SetActive(false);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                _gameManager.objetosIntarativos[13].SetActive(false);
                for (int i = 15; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }
            }
            if (valor == 15)
            {
                _gameManager.objetosIntarativos[15].SetActive(true);
                _gameManager.objetosIntarativos[14].SetActive(false);
                _gameManager.objetosIntarativos[13].SetActive(false);
                _gameManager.objetosIntarativos[12].SetActive(false);
                _gameManager.objetosIntarativos[11].SetActive(false);
                _gameManager.objetosIntarativos[10].SetActive(false);
                _gameManager.objetosIntarativos[9].SetActive(false);
                _gameManager.objetosIntarativos[8].SetActive(false);
                _gameManager.objetosIntarativos[7].SetActive(false);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                _gameManager.objetosIntarativos[13].SetActive(false);
                for (int i = 16; i < limiteSuperior; i++)
                {
                    _gameManager.objetosIntarativos[i].SetActive(false);
                }
            }
            if (valor == 16)
            {
                _gameManager.objetosIntarativos[16].SetActive(true);
                _gameManager.objetosIntarativos[15].SetActive(false);
                _gameManager.objetosIntarativos[14].SetActive(false);
                _gameManager.objetosIntarativos[13].SetActive(false);
                _gameManager.objetosIntarativos[12].SetActive(false);
                _gameManager.objetosIntarativos[11].SetActive(false);
                _gameManager.objetosIntarativos[10].SetActive(false);
                _gameManager.objetosIntarativos[9].SetActive(false);
                _gameManager.objetosIntarativos[8].SetActive(false);
                _gameManager.objetosIntarativos[7].SetActive(false);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                _gameManager.objetosIntarativos[17].SetActive(false);
               
            }
            if (valor == 17)
            {
                _gameManager.objetosIntarativos[16].SetActive(false);
                _gameManager.objetosIntarativos[15].SetActive(false);
                _gameManager.objetosIntarativos[14].SetActive(false);
                _gameManager.objetosIntarativos[13].SetActive(false);
                _gameManager.objetosIntarativos[12].SetActive(false);
                _gameManager.objetosIntarativos[11].SetActive(false);
                _gameManager.objetosIntarativos[10].SetActive(false);
                _gameManager.objetosIntarativos[9].SetActive(false);
                _gameManager.objetosIntarativos[8].SetActive(false);
                _gameManager.objetosIntarativos[7].SetActive(false);
                _gameManager.objetosIntarativos[6].SetActive(false);
                _gameManager.objetosIntarativos[5].SetActive(false);
                _gameManager.objetosIntarativos[4].SetActive(false);
                _gameManager.objetosIntarativos[3].SetActive(false);
                _gameManager.objetosIntarativos[2].SetActive(false);
                _gameManager.objetosIntarativos[1].SetActive(false);
                _gameManager.objetosIntarativos[0].SetActive(false);
                _gameManager.objetosIntarativos[17].SetActive(true);

            }



            objetoLixo.SetActive(true);
            isLixo = false;


        } else if(isLixo == false)
        {

        }
    }


    private void OnMouseDown()
    {
        isInteracao = true;
        //isLixo = true;
    }

    private void OnMouseExit()
    {
        isInteracao = false;
       // isLixo = false;
    }
}
