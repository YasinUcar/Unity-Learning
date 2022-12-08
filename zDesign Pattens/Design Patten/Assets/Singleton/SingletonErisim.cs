using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonErisim : MonoBehaviour
{

    void Start()
    {
        print(Singleton.Instance.GetText());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
