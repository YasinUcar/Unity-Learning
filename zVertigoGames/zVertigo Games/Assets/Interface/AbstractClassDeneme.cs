using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AbstractClassDeneme : MonoBehaviour
{

    private void Start()
    {
        DerivedClass1 derivedClass1 = new DerivedClass1();
        derivedClass1.Deneme();


    }

}
#region  Abstract Class ile bir kalıtım alındıysa bu bir şablon oluşturur ve mecburen
//diğer kalıtım alan yerlerde kullanılmak zorundadır
class DerivedClass1 : BaseClass
{

}

abstract class BaseClass
{
    public void Deneme()
    {
        Debug.Log("Deneme yazisi");
    }
    #endregion
}

