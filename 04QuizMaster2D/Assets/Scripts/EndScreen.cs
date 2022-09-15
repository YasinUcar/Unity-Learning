using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper score;
    void Start()
    {
        score = ScoreKeeper.FindObjectOfType<ScoreKeeper>();
    }
    public void ShowFinalScore()
    {
        finalScoreText.text = "Final Score: " + score.CalculateScore() + "%";
    }


}
