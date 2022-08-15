using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] int mainThrust;
    [SerializeField] float rotateThrust;
    [SerializeField] AudioClip mainEngine;
    [SerializeField] ParticleSystem jetParticles, leftParticle, rightParticle;

    Rigidbody rb;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

    }


    void Update()
    {
        ProcessThrust();
        ProcessRotation();

    }
    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartThrust();

        }
        else
        {
            StopThrusting();
        }


    }
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();

        }
        else if (Input.GetKey(KeyCode.D))
        {
            RotateRight();

        }
        else
        {
            StopRotating();
        }
    }
    private void StartThrust()
    {
        rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(mainEngine);
        }
        if (!jetParticles.isPlaying)
        {
            jetParticles.Play();
        }
    }
    private void StopThrusting()
    {
        audioSource.Stop();
        jetParticles.Stop();
    }





    private void RotateRight()
    {
        ApplyRotation(-rotateThrust);
        if (!leftParticle.isPlaying)
        {
            leftParticle.Play();
        }
    }

    private void RotateLeft()
    {
        ApplyRotation(rotateThrust);
        if (!rightParticle.isPlaying)
        {
            rightParticle.Play();
        }
    }
    private void StopRotating()
    {
        rightParticle.Stop();
        leftParticle.Stop();
    }
    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
