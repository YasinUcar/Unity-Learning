using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    public delegate void ClickTest();
    public event ClickTest onLeftClick;
    public event ClickTest onRightClick;
    void Start()
    {
        onLeftClick += LeftClicker;
        onRightClick += RightClicker;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (onLeftClick != null)
                onLeftClick();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            if (onRightClick != null)
                onRightClick();
        }
    }
    public void LeftClicker()
    {
        Debug.Log($"Left click");
    }
    public void RightClicker()
    {
        Debug.Log($"Right click");
    }
}
