using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour
{
    //2) CRIE DOIS OBJETOS EM POSIÇÕES INICIAIS DIFERENTES QUE SE MOVIMENTAM PARA UM PONTO FINAL EM COMUM.

    //variavel publico para colocar um "tranform" de um objeto como alvo.
    public Transform alvo;

    //adiciona velocidade no objeto que conter esse script
    public float speed = 1f;
    

    // Update is called once per frame
    void Update()
    {
        //cria um vetor com o resultado da posição do objeto "alvo" subtraindo a posição objeto que conter esse script
        Vector3 direction = alvo.position - transform.position;

        //usa o vetor "direction" para definir como alvo para a atual posição do objeto que conter esse script.
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
