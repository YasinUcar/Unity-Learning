using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] int currentAmmo;
    public int GetAmmo()
    {
        return currentAmmo;
    }
    public void ReduceCurrentAmmo()
    {
        currentAmmo -= 1;
    }
}
