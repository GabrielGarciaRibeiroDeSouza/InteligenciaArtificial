using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover4 : MonoBehaviour
{
    /*
     * 4) CRIE CINCO PONTOS EM UM AMBIENTE E UM OBJETO;

        4.1) FA�A QUE O OBJETO PASSE PELOS PONTOS E AP�S A ULTRAPASSAGEM O PONTO DEVER� MUDAR DE COR;

            4.2) AO CHEGAR NO �LTIMO PONTO O OBJETO DEVE VOLTAR PARA PEN�LTIMO E PARAR SUA MOVIMENTA��O.
     */
    //variavel publico para colocar um "tranform" de um objeto como alvo.
    public Transform alvo;

    //adiciona velocidade no objeto que conter esse script
    public float speed = 1f;


    // Update is called once per frame
    void Update()
    {
        //cria um vetor com o resultado da posi��o do objeto "alvo" subtraindo a posi��o objeto que conter esse script
        Vector3 direction = alvo.position - transform.position;

        //usa o vetor "direction" para definir como alvo para a atual posi��o do objeto que conter esse script.
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
