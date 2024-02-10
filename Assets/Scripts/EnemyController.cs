using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
    [SerializeField] RoomController enemyRoom;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform targetPlayer;

    private void Awake()
    {
         enemyRoom.enemyCount++;
        agent = GetComponent<NavMeshAgent>();
        targetPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if(Vector3.Distance(targetPlayer.position, transform.position) < 10)
        {
            agent.destination = targetPlayer.position;
        }
        /*
        else
        {
            agent.destination = transform.position;
            transform.LookAt(targetPlayer.position);
        }
        */
    }

   
    public void OnDestroy()
    {
        enemyRoom.ReduceEnemyCount();
    }

}
