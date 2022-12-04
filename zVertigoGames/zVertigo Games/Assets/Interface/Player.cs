using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable<float>, IKillable
{
    private float _health = 100;
    public void Damage(float damageTaken)
    {
        _health -= damageTaken;
        
    }
    
    public void Kill()
    {

    }
}
