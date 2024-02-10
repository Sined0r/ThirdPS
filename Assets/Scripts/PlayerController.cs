using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] DoorController door;

    private void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {
            StartCoroutine(door.OpenDoor());
        }
    }
}
