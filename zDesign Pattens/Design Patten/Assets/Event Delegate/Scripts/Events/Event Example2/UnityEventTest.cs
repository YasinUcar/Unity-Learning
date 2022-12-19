using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class UnityEventTest : MonoBehaviour
{
    [System.Serializable] //monobehaviour olmayan yapıların inspecterdörde görünmesini istediğimizi için ekliyoruz
    public class OnClicked : UnityEvent
    {

    }
    [System.Serializable] public class OnPrinter : UnityEvent<int> { } //int döndürmesini istediğimizde

    public OnClicked onLeftCliked;
    public OnClicked onRightCliked;

    public OnPrinter onPrint;

    private void Start() //insectörden değilde kendimiz eklemek istediğimizde ise
    {
        onRightCliked.AddListener(RightClicker);//class olduğu için böyle bir ekleme yapmak zorundayız
        onPrint.AddListener(PrintValue);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onLeftCliked.Invoke();//bu bir class olduğu için  ınvoke yapıyorum
            onPrint.Invoke(5);
        }
        else if (Input.GetMouseButtonDown(1))
            onRightCliked.Invoke();
    }
    public void LeftClicker()
    {
        Debug.Log($"Left click");
    }
    public void RightClicker()
    {
        Debug.Log($"Right click");
    }
    public void PrintValue(int value)
    {
        Debug.Log(value);
    }
}
