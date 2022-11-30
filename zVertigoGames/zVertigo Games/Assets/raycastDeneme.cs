using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastDeneme : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit raycastHit;
        if (Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), out raycastHit))
        {

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * raycastHit.distance, color: Color.blue);
        }
    }
}
