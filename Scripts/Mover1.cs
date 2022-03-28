using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover1 : MonoBehaviour
{
    //1) CRIA A MOVIMENTA��O DE UM OBJETO ENTRE UM PONTO INICIAL E UM PONTO FINAL.

    //essa variavel define a posici��o do vetor.
    Vector3 alvo = new Vector3(3,0,2);
    //adiciona velocidade no objeto que conter esse scripts.
    public float speed = 1f;
    
    void Update()
    {
        //pega a posi��o do objeto que estiver portando esse script e usa o "Translate" para definir a dire��o que � o "alvo".
        transform.Translate(alvo.normalized * speed * Time.deltaTime);
    }
}
