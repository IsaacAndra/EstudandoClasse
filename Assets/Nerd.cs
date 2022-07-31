using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nerd : MonoBehaviour
{
    //Criando os atributos da minha classe

    [SerializeField] private string nome;
    private float numero;

    //Criando o atributo do ogro, que é quem vai me dar o método Apresnetar()

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

    //Eu vou passar um número para ele e ele vai dizer positivo se o número for positivo (maior ou igual a 0) ou dizer
    //Negativo se o número for menor do que 0
    //Tipo de acesso, retorno = void, parâmetro
    public void Conta(float numero)
    {
        if(numero >= 0)
        {
            Debug.Log("Positivo");
        }
        else
        {
            Debug.Log("Negativo");
        }
    }
    


}
