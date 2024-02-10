using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] float speed;
    private float timeToOpen = 2 ;
    private float openingTime = 0;

    public IEnumerator OpenDoor()
    {
        while(openingTime< timeToOpen)
        {
            openingTime+= Time.deltaTime;
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            yield return new WaitForSeconds (Time.deltaTime);
        }
    }
}
