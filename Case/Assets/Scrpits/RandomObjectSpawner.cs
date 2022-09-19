using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    [SerializeField] GameObject @object;


    void Start()
    {

    }
    void FixedUpdate()
    {
        if (this.gameObject.transform.childCount < 10)
        {
            StartCoroutine(SpawnObject());
        }


    }
    IEnumerator SpawnObject()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-5.51f, 6f), 0.25f, Random.Range(-17f, 8.50f));
        var objects = Instantiate(@object, randomSpawnPosition, Quaternion.identity);
        objects.transform.parent = gameObject.transform;
        yield return new WaitForSeconds(1f * Time.deltaTime);
    }
}