
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] int delayLevel = 2;
    [SerializeField] AudioClip[] sesler;
    [SerializeField] ParticleSystem successParticles;
    [SerializeField] ParticleSystem crashParticles;
   
    AudioSource audioSource;
    Movement movement;
    bool isTransitioning = false;
    void Start()
    {
        movement = GetComponent<Movement>();
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (isTransitioning) { return; }

        switch (other.gameObject.tag)
        {

            case "Friendly":
                print("Dostlara çaptın ");
                break;
            case "Finish":
                StartSuccessLevelSequence();
                break;
            default:
                StartCrashSequence();
                break;

        }

    }
    void StartCrashSequence()
    {
        isTransitioning = true;
        movement.enabled = false;
        crashParticles.Play();
        audioSource.Stop();
        audioSource.PlayOneShot(sesler[0]);
        Invoke("ReloadLevel", delayLevel);
    }
    void StartSuccessLevelSequence()
    {
        isTransitioning = true;
        movement.enabled = false;
        successParticles.Play();
        audioSource.Stop();
        audioSource.PlayOneShot(sesler[1]);

        Invoke("NextLevel", delayLevel);
    }
    private void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    void NextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);

    }

}
