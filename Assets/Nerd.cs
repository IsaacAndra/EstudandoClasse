using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nerd : MonoBehaviour
{
    //Criando os atributos da minha classe

    public string nome;

    //Criando o atributo do ogro, que � quem vai me dar o m�todo Apresnetar()

    public Ogro meuParca;

    // Start is called before the first frame update
    void Start()
    {
        meuParca.Apresentar(nome);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
