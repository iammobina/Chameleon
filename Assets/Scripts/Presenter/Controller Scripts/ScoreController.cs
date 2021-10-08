using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;
    public int score, highScore;
    public Text scoreText, highScoreText;

    void Awake()
    {
        MakeSingleton();
    }


    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Gameplay")
        {
            if (!scoreText)
                scoreText = GameObject.Find("ScoreText").GetComponent<Text>();

            scoreText.text = score.ToString();
        }else if(SceneManager.GetActiveScene().name == "DeathMenu")
        {
            if (!scoreText)
                scoreText = GameObject.Find("NumberScoreText").GetComponent<Text>();

            scoreText.text = score.ToString();

            if (!highScoreText)
                highScoreText = GameObject.Find("HighScoreNumberText").GetComponent<Text>();

            if(score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }

            highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
    }

    void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();

    }

    public void ResetScore()
    {
        score = 0;
    }

    public int GetScore() {
        return score;
    }
    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("HighScore");
    }
}
