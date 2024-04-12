using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    private NavMeshAgent agent;
    public Camera camera;
    public float speed;
    public Animator animator;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = agent.remainingDistance;
        if(Input.GetMouseButtonDown(0)){
        RaycastHit hit;
        if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit)){
            agent.SetDestination(hit.point);
        }
        }
        if(Input.GetMouseButtonDown(1)){
            animator.SetBool("talk", true);

        }
        if(Input.GetKeyDown(KeyCode.Space)){
             animator.SetBool("talk", false);
        }
        
    }
}
