using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover3 : MonoBehaviour
{
    //3) CRIE TR�S OBJETOS EM POSI��ES INICIAIS DIFERENTES, O PRIMEIRO E O SEGUNDO OBJETO IR�O PERSEGUIR O TERCEIRO, TODOS DEVERAM SE MOVIMENTAR.

    //variavel publico para colocar um "tranform" de um objeto como alvo.
    public Transform alvo;

    //adiciona velocidade no objeto que conter esse script
    public float speed = 1f;


    // Update is called once per frame
    void Update()
    {
        //cria um vetor com o resultado da posi��o do objeto "alvo" subtraindo a posi��o objeto que conter esse script
        Vector3 direction = alvo.position - transform.position;

        //define a dist�ncia que objeto vai ficar do alvo dele.
        if (direction.magnitude > 0.2f)
        {
            //usa o vetor "direction" para definir como alvo para a atual posi��o do objeto que conter esse script.
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
        
    }
}
