using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    [Header("SerializeField")]
    [SerializeField] GameObject deathVFX, hitVFX;

    [SerializeField] int scorePerHit = 15;
    [SerializeField] int enemyHealth = 3;
    [SerializeField] int scorePerEnemy = 1;

    GameObject spawner;
    ScoreBoad scoreBoard;
    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        scoreBoard = FindObjectOfType<ScoreBoad>(); //erişim
        AddRigibody();
    }

    private void AddRigibody()
    {
        
        Rigidbody rb = this.gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        KillEnemy();

    }
    private void ProcessHit()
    {
        HitEnemy(scorePerEnemy);
        scoreBoard.IncreaseScore(scorePerHit);
    }
    private void KillEnemy()
    {
        if (enemyHealth < 1)
        {
            GameObject vfx = Instantiate(deathVFX, transform.position, Quaternion.identity);//no rotation
            vfx.transform.parent = spawner.transform; // vfx'de oluşturduğumuz objeyi spawner'ın ebebeyni yap oluşturulan objeler burada
            Destroy(this.gameObject);
        }
    }
    private void HitEnemy(int damageHealth)
    {
        GameObject hitVfx = Instantiate(hitVFX, transform.position, Quaternion.identity);
        hitVfx.transform.parent = spawner.transform;
        enemyHealth -= damageHealth;

    }
}
