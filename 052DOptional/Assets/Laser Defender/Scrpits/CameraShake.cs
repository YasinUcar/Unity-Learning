using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] float shakeDuration = 0.5f;
    [SerializeField] float shakeMagnitude = 0.25f;

    Vector3 startingPosition; //camera
    void Start()
    {
        startingPosition = transform.position;
    }
    public void Play()
    {
        StartCoroutine(Shake());
    }
    IEnumerator Shake()
    {
        //insideUnitCircle =  Yarıçapı 1.0 (Salt Okunur) olan bir dairenin içinde veya üzerinde rastgele bir nokta döndürür. 
        float elapsedTime = 0; //geçen süre
        while (elapsedTime < shakeDuration)
        {
            transform.position = startingPosition + (Vector3)Random.insideUnitCircle * shakeMagnitude;
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame(); // komutlarımızı karenin sonuna kadar bekletmemizi sağlar.

        }
        transform.position = startingPosition; //return starting.poss
    }
}
