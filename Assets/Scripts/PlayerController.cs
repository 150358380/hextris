using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float smooth = 1f;
	private float degree;
	private float singleRotation = 60f;

	private void Start () {

	}

	private void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			degree += singleRotation;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			degree -= singleRotation;
		}
		transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler(0, 0, degree), 10 * smooth * Time.deltaTime);
	}
}
