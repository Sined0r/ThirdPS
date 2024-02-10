using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform gunPoint;

    [SerializeField] float bulletSpeed;
    [SerializeField] float reloadTime;

    float timer;
    bool canShoot;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            canShoot = true;
            timer = reloadTime;
        }
        else
        {
            canShoot = false;
        }

        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit);

        if (canShoot)
        {
            if (hit.transform.gameObject.tag == "Player")
            {
                GameObject bullet = Instantiate(bulletPrefab, gunPoint.position,
                    bulletPrefab.transform.rotation);

                bullet.GetComponent<Rigidbody>().AddForce(gunPoint.forward
                    * bulletSpeed * Time.deltaTime, ForceMode.Impulse);

                canShoot = false;
            }
        }
    }

}
