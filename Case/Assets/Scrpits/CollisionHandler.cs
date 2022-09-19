using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] Transform player, enemy;
    [SerializeField][Range(0, 10000)] int lerpTime;

    ScoreKeeper score;

    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeper>();
    }
    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Player":
                score.AddScorePlayer();
                IncreaseScale(other.gameObject.transform);
                Destroy(this.gameObject);
                break;
            case "Enemy":
                score.AddEnemyScore();
                IncreaseScale(other.gameObject.transform);
                Destroy(this.gameObject);
                break;

        }
    }
    void IncreaseScale(Transform @transform)
    {
        @transform.transform.localScale += Vector3.Lerp(@transform.localScale, new Vector3(0.03f, 0.03f, 0), lerpTime * Time.deltaTime);
    }


}
