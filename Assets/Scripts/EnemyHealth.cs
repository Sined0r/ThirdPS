using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] DoorController doorToNextRoom;
    [SerializeField] FinishScript finishScript;

    public int enemyCount;

    public float value = 100;

    public void DealDamage(float damage)
    {
       
        value -= damage;
        if (value <= 0)
        {
            Destroy(gameObject);
        
        }
    }

    private void Start()
    {
        finishScript = FindObjectOfType<FinishScript>();
        finishScript.allEnemiesCount += enemyCount;
    }

    public void ReduceEnemyCount()
    {
        enemyCount--;
        finishScript.ReduceEnemies();

        if (enemyCount <= 0)
        {
            StartCoroutine(doorToNextRoom.OpenDoor());
        }
    }
}
