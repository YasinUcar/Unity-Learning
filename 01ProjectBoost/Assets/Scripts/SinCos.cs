using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinCos : MonoBehaviour
{
    [SerializeField] float hiz;
    [SerializeField] float uzunluk;
    void Update()
    {
        float x = Mathf.Cos(Time.time*hiz)*uzunluk;//Cos = x ekseni y = sin ekseni
        //uzunluk değeriyle artık sin -1 + 1 değerlerini manipüle ediyoruz verdiğimiz değer kadar - ve + işlemler uyguluyor 
        float y = Mathf.Sin(Time.time * hiz) * uzunluk; 
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
