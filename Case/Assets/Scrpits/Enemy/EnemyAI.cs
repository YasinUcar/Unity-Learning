using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent navMeshAgent;
    ScoreKeeper score;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeper>();
    }
    void Update()
    {
        FindClosestEnemy();

    }
    void FindClosestEnemy()
    {
        //referans : https://www.youtube.com/watch?v=YLE3v8bBnck
        float distanceToClosestEnemy = Mathf.Infinity;
        CollisionHandler closestEnemy = null;
        CollisionHandler[] allEnemies = GameObject.FindObjectsOfType<CollisionHandler>();
        foreach (CollisionHandler currentEnemy in allEnemies)
        {
            float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceToClosestEnemy)
            {
                distanceToClosestEnemy = distanceToEnemy;
                closestEnemy = currentEnemy;
            }
        }
        (int scorePlayer, int scoreEnemy) scores = (score.GetScorePlayer(), score.GetScoreEnemy());

        if (scores.scoreEnemy > scores.scorePlayer)
        {
            navMeshAgent.SetDestination(target.transform.position);
        }
        else
        {
            navMeshAgent.SetDestination(closestEnemy.transform.position);
        }

    }
}

