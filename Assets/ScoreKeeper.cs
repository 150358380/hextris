using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public Text scoreText;
	public Text livesText;

	private int score;
	private int lives = 5;

	private void Start () {
		UpdateScoreText ();
	}

	public void IncreaseScore (int value) {
		score += value;
		UpdateScoreText ();
	}

	public void DecreaseLives () {
		lives--;
		UpdateLivesText ();
		if (lives <= 0) {

		}
	}

	private void UpdateScoreText () {
		scoreText.text = "Score: " + score.ToString ();
	}

	private void UpdateLivesText () {
		livesText.text = "Lives: " + lives.ToString ();
	}
}
