using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
       highscore = PlayerPrefs.GetInt("highscore", 0);
       scoreText.text =  "POINTS:" + score.ToString() ;
       highscoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        score += 100;
        scoreText.text = score.ToString() + "POINTS:";
        if(highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        
    }
}