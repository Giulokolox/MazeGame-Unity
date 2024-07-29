using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public Transform player;  
    private NavMeshAgent agent; 

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (player != null)
        {
            Vector3 playerPosition = player.position;

            
            if (CanSeePlayer(playerPosition))
            {
                agent.SetDestination(playerPosition);
            }
            else
            {
               
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, 1.0f))
                {
                    if (hit.collider.CompareTag("Wall"))
                    {
                        Vector3 avoidPoint = transform.position + Vector3.Reflect(transform.forward, hit.normal);
                        agent.SetDestination(avoidPoint);
                    }
                }
            }
        }
    }

    private bool CanSeePlayer(Vector3 playerPosition)
    {
        
        return true;
    }


}
