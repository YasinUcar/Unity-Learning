using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable<T>
{
    void Damage(T damageTaken); //burada bulunan T hangi veri gelirse kabul edeceğini söylüyor int,float byte vb. bunlar için ayrı değişken oluşturmamış oluyoruz
    
}
public interface IKillable
{
    void Kill();
}