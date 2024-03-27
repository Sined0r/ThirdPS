using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    public FireBall fireballPrefab;
    public Transform fireballSourceTransform;

    [SerializeField] AudioSource shootSound;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, fireballSourceTransform.position, 
                fireballSourceTransform.rotation);

            shootSound.PlayOneShot(shootSound.clip);
        }
    }
}
