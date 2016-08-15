using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject[] balls;

	private void Start () {
		InvokeRepeating ("SpawnBalls", 2f, 1.5f);
	}

	private void SpawnBalls () {
		GameObject ball = Instantiate(balls[Random.Range(0, balls.Length)]);
		ball.transform.SetParent (this.transform);
	}
}
