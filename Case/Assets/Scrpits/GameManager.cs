using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject pauseCanvas;
    ScoreKeeper score;
    float time = 60f;
    void Start()
    {
        timerText.text = "0";
        scoreText.text = "0";
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeper>();
        Time.timeScale = 1;
    }


    void Update()
    {
        Coutdown();
        ScoreText();

    }
    void Coutdown()
    {
        time -= Time.deltaTime;
        timerText.text = Mathf.RoundToInt(time).ToString();
        if (time <= 0)
        {
            ReplayGame();
        }
    }
    void ScoreText()
    {
        scoreText.text = score.GetScorePlayer().ToString();
    }
    public void PauseButton()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void ReplayGame()
    {
        int nowScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nowScene);
    }

}
