using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    Transform goal;
    float speed = 5f;
    float accuracy = 1f;
    float rotSpeed = 2f;

    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    int currentWP = 0;
    Graph graph;

    void Start()
    {
       wps = wpManager.GetComponent<WPManager>().waypoints;
       graph = wpManager.GetComponent<WPManager>().graph;
       currentNode = wps[0];
    }

    public void GoToHeli()
    {
        graph.AStar(currentNode, wps[1]);
        currentWP = 0;
    }

    public void GoToRuin()
    {
        graph.AStar(currentNode, wps[6]);
        currentWP = 0;
    }

    void LateUpdate()
    {
        if (graph.getPathLength() == 0 || currentWP == graph.getPathLength())
        {

        }
    }
}
