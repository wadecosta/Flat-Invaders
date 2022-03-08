using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static TextMeshProUGUI score_text;

    // Start is called before the first frame update
    void Start()
    {
	    TextMeshProUGUI score_text = GetComponent<TextMeshProUGUI>();
	    score_text.SetText("SCORE: 0000");
        
    }

    // Update is called once per frame
    void Update()
    {
	    TextMeshProUGUI score_text = GetComponent<TextMeshProUGUI>();
	    if(score < 10)
	    {
		    score_text.SetText("SCORE: 000" + score.ToString());
	    }
	    else if(score < 100)
	    {
		    score_text.SetText("SCORE: 00" + score.ToString());
	    }
	    else if(score < 1000)
	    {
		    score_text.SetText("SCORE: 0" + score.ToString());
	    }
	    else
	    {
		    score_text.SetText("SCORE:" + score.ToString());
	    }
        
    }
}
