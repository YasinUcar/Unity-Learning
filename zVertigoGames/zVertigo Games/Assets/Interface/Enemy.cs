using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable<int> //istediğim tür
{
    private int _health = 100;
    public void Damage(int damageTaken)
    {
        damageTaken -= _health;
    }
    
}
