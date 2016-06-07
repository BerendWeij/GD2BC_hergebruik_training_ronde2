using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	[SerializeField]private float _speed;
	[SerializeField]private float _rotateSpeed;

	public void Move(float y) {
		Vector2 position = transform.position;
		position.x += transform.up.x * y * _speed * Time.deltaTime;
		position.y += transform.up.y * y * _speed * Time.deltaTime;
		transform.position = position;
	}

	public void Rotate(float x) {
		Vector3 rotation = transform.rotation.eulerAngles;	
		rotation.z -= x * _rotateSpeed * Time.deltaTime;
		transform.rotation = Quaternion.Euler(rotation);
	}
}
