using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonYontemUc : MonoBehaviour
{
    public static SingletonYontemUc _instance;
    public static SingletonYontemUc Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SingletonYontemUc>();
                if (_instance == null)
                {
                    _instance = new GameObject("Game Manager").AddComponent<SingletonYontemUc>();
                }

            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance != null) //fazladan obje oluşturmamak için
            Destroy(this); 
        DontDestroyOnLoad(this); //yok etme audiomanager için kullanılabilir

    }
}
