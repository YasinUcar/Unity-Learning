using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 50;
    void OnTriggerEnter2D(Collider2D other)
    {

        Damage damage = other.GetComponent<Damage>();
        if (damage != null)
        {
            TakeDamage(damage.GetDamage());
            damage.Hit();
        }
    }
    void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
