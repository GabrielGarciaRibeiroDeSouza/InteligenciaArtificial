using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollow : MonoBehaviour
{
    //cria um array de objetos chamado "waypoints"
    public GameObject[] waypoints;
    int currentWP = 0;

    //atributos do objeto que estiver portando o script
    float speed = 1.0f;
    float accuracy = 1.0f;
    float rotSpeed = 0.4f;
    

    void Start()
    {
        //busca os objetos com a tag "waypoint" e armazena no array de waypoints
        waypoints = GameObject.FindGameObjectsWithTag("waypoint");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //se tiver algum objeto no indice 0, retorna
        if (waypoints.Length == 0) return;
        //cria um vetor para armazenar a posição atual do objeto no array
        Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x,
        this.transform.position.y,
        waypoints[currentWP].transform.position.z);
        //cria um vetor para armazenar a direção, depois define que a rotação deste objeto seja de acordo com a velocidade de rotação definida e rotaciona para a direção
        Vector3 direction = lookAtGoal - this.transform.position;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
        Quaternion.LookRotation(direction),
        Time.deltaTime * rotSpeed);
        //verifica se a magnitude "colidio" com accuracy
        if (direction.magnitude < accuracy)
        {
            //adiciona +1 no indice do array
            currentWP++;
            //se o waypoint atual for maior ou igual ao tamnho limite
            if (currentWP >= waypoints.Length)
            {
                //define o array como indice 0
                currentWP = 0;
            }
        }
        //adiona movimento ao objeto com a velocidade defina em "speed"
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
