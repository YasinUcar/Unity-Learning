using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    void Start()
    {

    }


    private void OnEnable()
    {
        EventManager.OnMouseClick += SkorArttir;
        //lamba ext.
        // EventManager.OnMouseClick += () => score++; //temelde yukarda olan işlemin  ve altta olan fonksiyon işleminin aynısını yapar bir fonksiyon açar ve score++ yı döndürür 
    }
    private void OnDisable()
    {
        EventManager.OnMouseClick -= SkorArttir;
    }
    private void SkorArttir()
    {
        score++;
    }
}
