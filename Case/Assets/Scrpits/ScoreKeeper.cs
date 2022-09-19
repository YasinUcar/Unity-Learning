using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int playerScore = 0;
    int enemyScore = 0;

    public void AddScorePlayer()
    {
        playerScore += 100;
    }
    public int GetScorePlayer()
    {
        return playerScore;
    }
    public void AddEnemyScore()
    {
        enemyScore += 100;
    }
    public int GetScoreEnemy()
    {
        return enemyScore;
    }
}
