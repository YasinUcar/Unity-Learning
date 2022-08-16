using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscllitaor : MonoBehaviour
{
    [SerializeField] Vector3 movementVector;
    [SerializeField][Range(0, 1)] float movementFactor;
    [SerializeField] float period = 2f;
    Vector3 startingPos;
    void Start()
    {
        startingPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon) { return; } //Epsilon: Float tipinde 0’dan sonraki en küçük sayı değeridir. 0f kullanmak yerine kullandık float'ın mirko değerleri için
        float cycles = Time.time / period; //zamanla büyür

        const float tau = Mathf.PI * 2;//6.283
        float rawSinWawe = Mathf.Sin(cycles * tau); //-1 to 1

        movementFactor = (rawSinWawe + 1) / 2; //-1 den +1'e değil 0'dan 1'e gitmek istiyoruz 0-2 veriyor /2 ile 0-1 veriyor

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;
    }
}
