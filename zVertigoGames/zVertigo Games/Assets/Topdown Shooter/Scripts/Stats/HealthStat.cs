using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TopDownShooter.Health
{
    public class HealthStat : MonoBehaviour
    {
        private float _health = 100f;
        public void Hit(float damage)
        {
            _health -= damage;
            if (_health <= 0)
            {
                print("Health zero");
            }
            else
            {
                print("current health: " + _health);
            }
        }
    }
}