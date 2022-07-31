using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogro : MonoBehaviour
{
    //Pensando nos atributos do Ogro
    //Os atributos de uma Classe, são as suas variáveis.

    //Vida, velocidade, nome próprio.
    [SerializeField] private float vida = 10f;
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private string nome = "Josué";
    public Nerd nerd;


    // Start is called before the first frame update
    void Start()
    {
        //Fazendo o ogro se apresentar
        Apresentar(nome);
        nerd.Conta(vida);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Criando o Método de apresentação
    public void Apresentar(string nome)
    {
        //Esse código é o meu método
        Debug.Log("Prazer meu nome é " + nome);
    }



}
