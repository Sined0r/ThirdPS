using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform shootPoint;
    [SerializeField] float power;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            GameObject newBullet = Instantiate(bullet, shootPoint.position, bullet.transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(shootPoint.forward * power * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
