using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class doorOne : MonoBehaviour
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
        cam.transform.position = new Vector3(-20.51f, 9.26f, -3.41f);
        Vector3 newPosition = new Vector3(-21f, 1.41f, -4.34f);
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
