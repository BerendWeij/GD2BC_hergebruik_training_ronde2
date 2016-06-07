using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour, IDestructable {
	private float _speed = 7.5f;
	private float _maxTime = 4f;
	private float _time;
	void Update () {
		_time += Time.deltaTime;
		if (_time > _maxTime) {
			Destruct ();
			_time = 0;
		}

		Vector2 position = transform.position;
		position.x += transform.up.x * _speed * Time.deltaTime;
		position.y += transform.up.y * _speed * Time.deltaTime;
		transform.position = position;
	}

	public void Destruct() {
		Destroy (this.gameObject);
	}
}
