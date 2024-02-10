using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float damage;
    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        HP hpobj = collision.gameObject.GetComponent<HP>();

        if (hpobj) hpobj.TakeDamage(-damage);

        Destroy(gameObject);
    }
}
