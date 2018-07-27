using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIMovement : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform Destination;
    public AIControl control;

    private void Start()
    {
        control.ConfigAI(agent);
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = Destination.position;   
    }
}
