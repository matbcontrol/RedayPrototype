using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class doorTwo : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;
    
    public GameObject dark;
    public GameObject dark1;
    private NavMeshAgent playerAgent;
    void Start()
    {playerAgent = player.GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        cam.transform.position = new Vector3(-15.41f,9.26f,-10.08f);
        Vector3 newPosition = new Vector3(-12.76f,1.401f,-13.65f);
        ToggleAgent(newPosition);
        Debug.Log("Click");
    }
    public void ToggleAgent(Vector3 newPosition)
{
    if (playerAgent != null)
    {
        // Отключение NavMeshAgent
        playerAgent.enabled = false;

        // Перемещение объекта
        player.transform.position = newPosition;

        // Повторное включение NavMeshAgent
        playerAgent.enabled = true;
        dark.SetActive(false);
        dark1.SetActive(true);

    }
    else
    {
        Debug.LogError("Player object is missing a NavMeshAgent component!");
    }
}
}
