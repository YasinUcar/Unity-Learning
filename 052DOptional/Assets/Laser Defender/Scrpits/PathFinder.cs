using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{
    [SerializeField] WaveConfigSO waveConfig;
    List<Transform> waypoints;
    int waypointIndex = 0;
    void Start()
    {
        waypoints = waveConfig.GetWayPoints();
        transform.position = waypoints[waypointIndex].position;
    }


    void Update()
    {
        FollowPath();
    }
    void FollowPath()
    {
        if (waypointIndex < waypoints.Count)
        {
            Vector3 targetPosition = waypoints[waypointIndex].position;
            float delta = waveConfig.GetMoveSpeed() * Time.deltaTime;
            //MoveTowards (): Başlangıç ve bitiş noktalarını verdiğimiz ve adım adım başlangıçtan bitişe hareket etmemizi sağlayan fonksiyondur. 
            //Daha yumuşak ve kontrollü bir hareket elde etmemizi sağlar.
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, delta);
            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
