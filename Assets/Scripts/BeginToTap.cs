using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeginToTap : MonoBehaviour {

	public bool startGame = true;
	public Text HighScoreText;

	void Start() 
	{
		HighScoreText.text = "HighScore: " + PlayerPrefs.GetInt ("highScore").ToString();
	}

	// Update is called once per frame
	void Update () 
	{
		if(startGame && Input.GetMouseButtonDown (0))
		{
			SceneManager.LoadScene ("InGame");
		}

		if (PlayerPrefs.GetInt ("highScore") < GameControl.instance.score) 
		{
			PlayerPrefs.GetInt ("highscore", GameControl.instance.score);
			HighScoreText.text = "HighScore: " + GameControl.instance.score;
		}
	}
}
