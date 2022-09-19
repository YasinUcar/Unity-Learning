using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderForce : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    bool vurdu;
    ScoreKeeper score;
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeper>();
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            vurdu = true;

        }

    }
    void OnCollisionExit(Collision other)
    {
        vurdu = false;
    }
    void Update()
    {
        if (vurdu == true)
        {
            StartCoroutine("AddForce");
        }
    }
    void AddForce()
    {
        int scoreEnemy = score.GetScoreEnemy();
        int scorePlayer = score.GetScorePlayer();

        if (scoreEnemy > scorePlayer)
        {

            gameObject.GetComponent<Rigidbody>().AddForce(scoreEnemy * Time.deltaTime * 20, 0, scoreEnemy * Time.deltaTime * 20);

        }
        if (scorePlayer > scoreEnemy)
        {
            enemy.GetComponent<Rigidbody>().AddForce(scorePlayer * Time.deltaTime * 20, 0, scorePlayer * Time.deltaTime * 20);



        }
    }
}
