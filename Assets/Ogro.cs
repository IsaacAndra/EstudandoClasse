using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogro : MonoBehaviour
{
    //Pensando nos atributos do Ogro
    //Os atributos de uma Classe, s�o as suas vari�veis.

    //Vida, velocidade, nome pr�prio.
    public float vida = 10f;
    public float velocidade = 5f;
    public string nome = "Josu�";


    // Start is called before the first frame update
    void Start()
    {
        //Fazendo o ogro se apresentar
        Apresentar(nome);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Criando o M�todo de apresenta��o
    public void Apresentar(string nome)
    {
        //Esse c�digo � o meu m�todo
        Debug.Log("Prazer meu nome � " + nome);
    }



}
