using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {
	private PlayerMovement _playerMovement;

	private void Start() {
		_playerMovement = GetComponent<PlayerMovement> ();
	}

	private void Update() {
		float x = Input.GetAxis (InputStrings._horizontalInput);
		float y = Input.GetAxis (InputStrings._verticalInput);
		if (y != 0) {
			_playerMovement.Move (y);
		} 

		if (x != 0) {
			_playerMovement.Rotate (x);
		}
	}
}
