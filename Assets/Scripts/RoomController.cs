using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    [SerializeField] DoorController doorToNextRoom;
    [SerializeField] FinishScript finishScript;

    public int enemyCount;

    private void Start()
    {
        finishScript = FindObjectOfType<FinishScript>();
        finishScript.allEnemiesCount += enemyCount;
    }

    public void ReduceEnemyCount()
    {
        enemyCount--;
        finishScript.ReduceEnemies();

        if(enemyCount <= 0)
        {
            StartCoroutine(doorToNextRoom.OpenDoor());
        }
    }

}
