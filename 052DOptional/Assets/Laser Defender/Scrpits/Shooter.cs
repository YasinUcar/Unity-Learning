using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectTilePrefab;
    [SerializeField] float projectTileSpeed = 10f;
    [SerializeField] float projectTileLifeTime = 5f;

    [SerializeField] float firingRate = 0.2f;
    public bool isFiring;
    Coroutine firingCoroutine;
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
            yield return new WaitForSeconds(firingRate);

        }
    }
}
