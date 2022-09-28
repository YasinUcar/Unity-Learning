using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [Header("General")]
    [SerializeField] GameObject projectTilePrefab;
    [SerializeField] float projectTileSpeed = 10f;
    [SerializeField] float projectTileLifeTime = 5f;
    [SerializeField] float baseFiringRate = 0.2f;
    [Header("AI")]
    [SerializeField] bool useAI;

    [SerializeField] float firingRateVariance = 0f;
    [SerializeField] float minimumFiringRate = 0.1f;
    [HideInInspector] public bool isFiring;
    Coroutine firingCoroutine;
    void Start()
    {
        if (useAI)
        {
            isFiring = true;
        }
    }
    void Update()
    {
        Fire();
    }
    void Fire()
    {
        if (isFiring && firingCoroutine == null) //firingCoroutine null diyerek daha sonra çalışmasını engelliyoruz başta null olarak geliyor ve bir kere tetkilenmesi sağlanıyor
            firingCoroutine = StartCoroutine(FireContinuosly());
        else if (!isFiring && firingCoroutine != null)
        {
            StopCoroutine(firingCoroutine);
            firingCoroutine = null;
        }
    }
    IEnumerator FireContinuosly()
    {
        while (true)
        {
            GameObject instance = Instantiate(projectTilePrefab, transform.position, Quaternion.identity);
            instance.GetComponent<Rigidbody2D>().velocity = transform.up * projectTileSpeed; //transform up yeşil noktayı temsil eder yani yeşil nokta y den ileriye değer verir.
            Destroy(projectTilePrefab, projectTileLifeTime);
            float timeToNextProjectile = Random.Range(baseFiringRate - firingRateVariance, baseFiringRate + firingRateVariance);
            timeToNextProjectile = Mathf.Clamp(timeToNextProjectile, minimumFiringRate, float.MaxValue);
            yield return new WaitForSeconds(timeToNextProjectile);

        }
    }
}
