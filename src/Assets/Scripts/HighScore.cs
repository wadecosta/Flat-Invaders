using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public static int highScore = 0;
    public static TextMeshProUGUI high_score_text;
    // Start is called before the first frame update
    void Start()
    {
	    TextMeshProUGUI high_score_text = GetComponent<TextMeshProUGUI>();
            high_score_text.SetText("HIGH SCORE: hello");
	    highScore = PlayerPrefs.GetInt("highscore2");
    }

    // Update is called once per frame
    void Update()
    {
	    TextMeshProUGUI high_score_text = GetComponent<TextMeshProUGUI>();


	    if(Score.score > highScore)
	    {
		    highScore = Score.score;
	    }



	    if(highScore < 10)
	    {
		    high_score_text.SetText("HIGH SCORE: 000" + highScore.ToString());
	    }
	    else if(highScore < 100)
	    {
		    high_score_text.SetText("HIGH SCORE: 00" + highScore.ToString());
	    }
	    else if(highScore < 1000)
	    {
		    high_score_text.SetText("HIGH SCORE: 0" + highScore.ToString());
	    }
	    else
	    {
		    high_score_text.SetText("HIGH SCORE:" + highScore.ToString());
	    }
	    
	    PlayerPrefs.SetInt("highscore2", highScore);
        
    }
}
