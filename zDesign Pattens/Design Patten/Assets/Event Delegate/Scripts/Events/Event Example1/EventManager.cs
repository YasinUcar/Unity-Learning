using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void MouseClickDelegate();
    public static MouseClickDelegate OnMouseClick;


    void Update()
    {
        //bu event'i eğer onMouseClick'e bastıysam çağıraacak ve bunun dinleyicileride bu olduğunda bunu başlatacak.
        if (Input.GetMouseButtonDown(0)) 
        {
            if (OnMouseClick != null)
            {
                OnMouseClick();
            }
        }
    }
}
