
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathTest : MonoBehaviour
{
    public delegate int CalculateDelegate(int x1, int x2);
    public CalculateDelegate calculateDelegate;

    private void Start()
    {
        AddMethod(Toplama);
        AddMethod(Cikarma);
        AddMethod(Carpma);

        //tek tek değerli okuyalım
        System.Delegate[] funcs = calculateDelegate.GetInvocationList(); //getinvo ile tanımlı metotların listesini func isimli değişkenlerimize atadık.

        for (int i = 0; i < funcs.Length; i++)
        {
            int result = ((CalculateDelegate)funcs[i]).Invoke(5, 2); //delagete olarak geldiği için dönüşütürdük 2 parantez var çünkü diğer kısmı ayırmak istedik
            print(result);
        }


    }
    private int Toplama(int a, int b)//delegate'den istenen method ile istenen değerler aynı olmak zorunda
    {
        return a + b;
    }
    private int Cikarma(int a, int b)//delegate'den istenen method ile istenen değerler aynı olmak zorunda
    {
        return a - b;
    }
    private int Carpma(int a, int b)//delegate'den istenen method ile istenen değerler aynı olmak zorunda
    {
        return a * b;
    }
    public void AddMethod(CalculateDelegate method)
    {
        calculateDelegate += method;
    }



}
