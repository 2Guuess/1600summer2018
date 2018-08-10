using UnityEngine;
using System;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    private void Start()
    {
        cam = FindObjectOfType<Camera>();
    }

    void Update ()
    {

        Touch myTouch = Input.GetTouch(0);
        Touch[] touches = Input.touches;
        for(int i = 0; i < Input.touchCount; i++)
        {
            //Do Something
        }


        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
	}
}
