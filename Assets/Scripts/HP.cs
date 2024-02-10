using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    [SerializeField] Text hpText;
    [SerializeField] float maxHP;
    float currHP;

    void Start()
    {
        currHP = maxHP;
        if(hpText) hpText.text = $"{currHP} / {maxHP}";
    }

    public void TakeDamage(float damage)
    {
        currHP = Mathf.Clamp(currHP + damage, 0f, maxHP);

        if (hpText) hpText.text = $"{currHP} / {maxHP}";

        if (currHP <= 0f) Destroy(gameObject);
    }
}
