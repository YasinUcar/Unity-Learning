using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Serileştirilmiş")]
    [Tooltip("Gemi ne kadar hızlı")][SerializeField] float speed = 30f; //Toltip unity üzerinde üzerine gelince textbox açar
    [SerializeField] float xRange = 7.50f;
    [SerializeField] float yRange = 4f;
    [SerializeField] float positionPitchFactor = -15f, positionYawFactor = -2f;
    [SerializeField] float controlPitchFactor = -10f, controlRollFactor = -20f;
    [SerializeField] GameObject[] lasers;

    CollisionHandler col;
    [Header("Sayısal")]
    float yInput, xInput;
    bool gameOver = false;
    void Start()
    {
        col = GetComponent<CollisionHandler>();
    }
    void Update()
    {
        ProcessTranslation();
        ProcessRotation();
        ProcessFiring();
    }
    void ProcessRotation()
    {
        float pitch = transform.localPosition.y * positionPitchFactor + yInput * controlPitchFactor; //yunuslama (Veya dalış) //YInput = yalpalamayı daha doğal olmasını sağlar etkisini arttırmak içöin controllerpitchfactor ile çarpılır 
        float yaw = transform.localPosition.x * positionYawFactor + xInput; //sapma (Veya yalpalama)
        float roll = +xInput * controlRollFactor;//yatış (Veya dönme)

        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }
    private void ProcessTranslation()
    {
        xInput = Input.GetAxis("Horizontal");

        yInput = Input.GetAxis("Vertical");


        float Xpos = transform.localPosition.x + xInput * Time.deltaTime * speed;
        float clampXPos = Mathf.Clamp(Xpos, -xRange, xRange);

        float yPos = transform.localPosition.y + yInput * Time.deltaTime * speed;
        float clampYPos = Mathf.Clamp(yPos, -yRange, yRange);

        transform.localPosition = new Vector3(clampXPos, clampYPos, transform.localPosition.z);
    }
    void ProcessFiring()
    {

        if (Input.GetButton(buttonName: "Fire1"))
        {

            SetLaserActive(true);
        }
        else
        {
            SetLaserActive(false);
        }



    }
    void SetLaserActive(bool acikMi)
    {
        // laser.SetActive(true); //not active setactive daha yeni ve childrenlarda daha kullanışlı 
        foreach (GameObject laser in lasers)
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;   //var = ParticleSystem.EmissionModule
            emissionModule.enabled = acikMi;
        }
    }

}
