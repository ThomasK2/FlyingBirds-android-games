using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject GameOverText;
	public GameObject Birds;
	public GameObject highScore;
	public Text scoreText;
	public Text highScoreText;
	public bool gameOver = false;

	public float scrollSpeed = -1.5f;

	public int score;
	private int highscore;

	void Start() 
	{
		highScoreText.text = "HighScore: " + PlayerPrefs.GetInt ("highScore").ToString ();
	}

	void Awake () 
	{
		if (instance == null) 
		{
			instance = this;
		} else if (instance != this) 
		{
			Destroy (gameObject);
		}
	}

	public void UpdateScored()
	{
		score += 1;
		scoreText.text = "Score: " + score.ToString ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameOver == true && Input.GetMouseButtonDown (0)) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			GameOverText.SetActive(false);
			Birds.SetActive (true);
		}
	}

	public void GameOver()
	{
		gameOver = true;
		GameOverText.SetActive (true);
		highScore.SetActive (true);

		if (PlayerPrefs.GetInt ("highScore") < score) 
		{
			PlayerPrefs.SetInt ("highScore", score);
			highScoreText.text = "HighScore: " + score.ToString ();
		}
	}
}