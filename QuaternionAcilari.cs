using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionAcilari : MonoBehaviour
{
    private Transform cube1, cube2;


    // Update is called once per frame
    void Update()
    {

        #region Source : https://ogreniyoruz.net/unity-transform-ve-quaternion-sinifi/ || https://gist.github.com/sem1h/1671f16b9f3a560ea29711f27e92c1df


        // Angel metodu iki obje arasındaki açıyı bize derece olarak döndürür.
        Quaternion.Angle(cube1.rotation, cube2.rotation);

        //Quaternion sınıfındaki Inverse metodu ile hedef olarak belirlediğiniz objede gerçekleşen “Rotation” işlemleri, ana objede de tam tersi şekilde gerçekleşir.
        transform.rotation = Quaternion.Inverse(cube2.rotation);

        //Euler : Quaternion sınıfındaki Euler metodu ile oyunumuzun başlangıcında ya da belirli bir aşamasında istediğiniz açıda yön değiştirmesini sağlayabilirsiniz. Euler metodu X,Y ve Z koordinat bilgileri parametre olarak alır ve bu parametrelerde belirtilen açıları sırasıyla uygulamaya geçirir. 

        transform.rotation = Quaternion.Euler(90, 0, 0);

        //identity Quaternion sınıfındaki identity özelliği sayesinde objede olan mevcut rotasyonları sıfırlayabilirsiniz.

        transform.rotation = Quaternion.identity;
        #endregion
    }
}
