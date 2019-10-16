using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{

    public bool chase = false;
    public Camera cam;
    public NavMeshAgent agent;
    public Transform playerTrans;
    void Update() { 

        if (chase) {
            agent.SetDestination(playerTrans.position);
        }

        else if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
