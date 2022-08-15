
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] int delayLevel = 2;
    [SerializeField] AudioClip[] sesler;
    AudioSource audioSource;
    Movement movement;
    void Start()
    {
        movement = GetComponent<Movement>();
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                print("Dostlara çaptın ");
                break;
            case "Finish":
                StartSuccessLevelSequence();
                break;
            case "Fuel":
                print("Yakit alindi");
                break;
            default:
                StartCrashSequence();
                break;
        }
    }
    void StartCrashSequence()
    {
        movement.enabled = false;
        audioSource.PlayOneShot(sesler[0]);

        Invoke("ReloadLevel", delayLevel);
    }
    void StartSuccessLevelSequence()
    {
        movement.enabled = false;
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
