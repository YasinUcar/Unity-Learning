using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        distanceToTarget = Vector3.Distance(transform.position, target.transform.position);

        if (distanceToTarget <= chaseRange)
        {
            navMeshAgent.SetDestination(target.transform.position);
        }

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
