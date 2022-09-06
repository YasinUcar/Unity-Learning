using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    Camera cam;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFOV = 20f;
    bool zoomInToogle = false;
    void Start()
    {
        cam = Camera.main;
    }


    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomInToogle)
            {
                zoomInToogle = true;
                WeaponZooming(zoomInFOV);
            }
            else
            {
                zoomInToogle = false;
                WeaponZooming(zoomOutFOV);
            }
        }

    }

    void WeaponZooming(float zoomingRate)
    {
        cam.fieldOfView = zoomingRate;
    }
}
