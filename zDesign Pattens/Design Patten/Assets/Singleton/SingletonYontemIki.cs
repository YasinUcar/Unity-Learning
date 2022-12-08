using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonYontemIki<T> : MonoBehaviour where T : SingletonYontemIki<T>
{
    //Bu yapıda bu yapıyı kullanan alt öğelere direk iletişim sağlanır bu yöntemde singleton erişimcisininin sahnede yer alması gerekir.

    //volatitile = multi tred için gereklidir ve burada direk olarak ram'den veri çekilir çünkü volatile ayrı bir yere koyar ara katmanlardan alsak sıkıntı çıkma ihtimali vardır
    private static volatile T instance = null; //hangi tür verildiyese

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(T)) as T; //sahneden T tipli veriyi çekiyoruz
            }
            return instance;
        }
    }


}
