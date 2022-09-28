using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 50;
    [SerializeField] bool applyCameraShake; //just myPlayer
    CameraShake cameraShake;
    void Start()
    {
        cameraShake = Camera.main.GetComponent<CameraShake>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        Damage damage = other.GetComponent<Damage>();
        if (damage != null)
        {
            TakeDamage(damage.GetDamage());
            ShakeCamera();
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
    void ShakeCamera()
    {
        if (cameraShake != null && applyCameraShake)
        {
            cameraShake.Play();
        }
    }
}
