using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    public static ScoreManager Instance
    {
        get
        {
            return instance;
        }
    }

    [SerializeField] private TextMeshProUGUI currentScoreValueText;
    [SerializeField] private TextMeshProUGUI bestScoreValueText;

    private int score;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Destroy(gameObject);
        }
    }


    private void Start()
    {
        currentScoreValueText.text = score.ToString();
        bestScoreValueText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        UpdateHighScore();
    }


    private void UpdateHighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            bestScoreValueText.text = score.ToString();
        }
    }


    public void UpdateScore()
    {
        score++;
        currentScoreValueText.text = score.ToString();
        UpdateHighScore();
    }

}
