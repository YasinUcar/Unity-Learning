using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
    [SerializeField] float turnSpeed = 5f;
    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;

    Animator anim;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        distanceToTarget = Vector3.Distance(transform.position, target.transform.position);

        if (isProvoked)
        {
            EngageTarget();
        }
        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;

        }

    }
    public void OnDamageTaken()
    {
        isProvoked = true;
    }
    private void EngageTarget()
    {
        FaceTarget();
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }
        if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            AttackTarget();
        }
    }

    private void ChaseTarget()
    {
        anim.SetBool("Attack", false);
        anim.SetTrigger("Move");
        navMeshAgent.SetDestination(target.position);
    }
    private void AttackTarget()
    {
        anim.SetBool("Attack", true);
        //   print(name + "saldırıyor " + target.name);
    }
    private void FaceTarget()
    {
        //normalized =  Vector3 değişkenini alıp, x,y,z bileşen değerlerini vektörün boyutu 1 birim olacak şekilde hesaplar. Vectorün sadece büyüklüğünü değiştirir, yönünde bir değişiklik olmaz. kısaca hızında bir değişiklik yapmaz
        //normalized  = https://www.youtube.com/watch?v=NiKxi8kWqNk
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed); //Slerp daha yumuşak geçişler için kullanılır 
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

}
