using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Dunya : MonoBehaviour
{
    public GameObject[] Agaclar;
    public GameObject[] Dunyalar;



    void DunyaDegisimi()
    {
        for (int i = 0; i < Agaclar.Length; i++)
        {
            if (!Agaclar[i].activeInHierarchy&& !Agaclar[1].activeInHierarchy && !Agaclar[2].activeInHierarchy && !Agaclar[3].activeInHierarchy && !Agaclar[4].activeInHierarchy )
            {
                Dunyalar[0].SetActive(false);
                Dunyalar[1].SetActive(true);

                break;
            }
        }
    }
    void Update()
    {
        DunyaDegisimi();
    }
}