using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapWater : MonoBehaviour
{

    [SerializeField] GameObject pauseCanvas, winnerText, enemys;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pauseCanvas.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        if (enemys.gameObject.transform.childCount <= 0)
        {
            pauseCanvas.SetActive(true);
            winnerText.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
