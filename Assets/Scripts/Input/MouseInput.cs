using UnityEngine;
using System.Collections;

public class MouseInput : MonoBehaviour {
	private PlayerShoot _playerShoot;

	private void Start() {
		_playerShoot = GetComponent<PlayerShoot> ();
	}

	private void Update() {
		if (Input.GetMouseButtonDown (0)) {
			_playerShoot.Shoot ();
		}
	}
}
