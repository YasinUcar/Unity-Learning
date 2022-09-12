using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    Camera cam;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFOV = 20f;
    [SerializeField] float zoomOutSensivity = 2f;
    [SerializeField] float zoomInSensivity = .5f;

    bool zoomInToogle = false;
    RigidbodyFirstPersonController rigidbodyFirstPersonController;

    void Start()
    {
        cam = Camera.main;
        //best method 
        rigidbodyFirstPersonController = GameObject.FindGameObjectWithTag("myPlayer").GetComponent<RigidbodyFirstPersonController>();
    }


    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomInToogle)
            {
                rigidbodyFirstPersonController.mouseLook.XSensitivity = zoomInSensivity;
                rigidbodyFirstPersonController.mouseLook.YSensitivity = zoomInSensivity;
                zoomInToogle = true;
                WeaponZooming(zoomInFOV);

            }
            else
            {
                rigidbodyFirstPersonController.mouseLook.XSensitivity = zoomOutSensivity;
                rigidbodyFirstPersonController.mouseLook.YSensitivity = zoomOutSensivity;
                zoomInToogle = false;
                WeaponZooming(zoomOutFOV);

            }
        }

    }

    void WeaponZooming(float zoomingRate)
    {
        cam.fieldOfView = zoomingRate;
    }
    void OnDisable()
    {
        WeaponZooming(zoomOutFOV);
    }
}
