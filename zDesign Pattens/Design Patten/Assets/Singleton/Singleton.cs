using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance = null;
    private string _text;

    public static Singleton Instance
    {

        get
        {
            if (instance is null)
                instance = new GameObject("Singleton").AddComponent<Singleton>();
            return instance;
        }

    }
    private void OnEnable() //daha önceden eklendiyse direk olarak bunu kullan //veya ilk oluştuğunda
    {
        instance = this;
        _text = "Hello World";
    }
    public string GetText()
    {
        return _text;
    }

}
