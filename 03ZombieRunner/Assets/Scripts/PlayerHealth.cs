using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float maxHealth = 100f;

    public void TakeDamage(float damage)
    {
        maxHealth -= damage;
        if (maxHealth <= Mathf.Epsilon)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }


}
