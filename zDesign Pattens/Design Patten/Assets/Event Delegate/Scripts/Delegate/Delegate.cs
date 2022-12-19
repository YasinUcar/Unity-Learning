using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{
    #region delegate'ler ile birden fazla fonksiyon ataması yapabilirim ve bunları istediğimiz yerlerde çağırtabiliriz
    public delegate void DelegateDebug(); //tanımalama
    public DelegateDebug delegateDebug; //obje oluşturma
    void Start()
    {
        delegateDebug += Debug1;
        delegateDebug += Debug2; //eşitleme yaparsak direk atar += diyerek liste gibi yan yana koyuoruz
        AddMethod(Debug4);//bu tarz bir kullanım daha mantıklı olacaktır
        delegateDebug -= Debug3; //sadece ekleme değil bu şekilde çıkarmada yapabiliyoruz
        if (delegateDebug != null)
            delegateDebug();
    }
    private void Debug1()
    {
        Debug.Log("Debug 1");
    }
    private void Debug2()
    {
        Debug.Log($"Debug deneme 2");
    }
    private void Debug3()
    {
        Debug.Log($"Ben zaten silineceğim");
    }
    private void Debug4()
    {
        Debug.Log($"fonkisyondan çağıralacağımn");
    }
    public void AddMethod(DelegateDebug method) //dışarıdan method eklemek istersek kullanabiliriz
    {
        delegateDebug += method;
    }
    public void RemoveMethod(DelegateDebug method) 
    {
        delegateDebug -= method;
    }
    #endregion

}
