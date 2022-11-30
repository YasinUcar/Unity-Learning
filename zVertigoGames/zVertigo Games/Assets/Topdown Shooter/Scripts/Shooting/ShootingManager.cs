using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.Health;
namespace TopDownShooter.Shooting
{
    public class ShootingManager : MonoBehaviour
    {

        public void Shoot(Vector3 from, Vector3 direction)
        {
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            bool rayHit = Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity);
            if (rayHit)
            {
                Debug.DrawLine(transform.position, transform.position + direction * 10, Color.red);
                print(hit.collider.name);
                HealthStat health = hit.collider.GetComponent<HealthStat>();
                if (health != null)
                {
                    health.Hit(5);
                }
            }
        }
    }
}