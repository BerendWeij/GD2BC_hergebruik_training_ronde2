using UnityEngine;
using System.Collections;

public class TurretShoot : MonoBehaviour {
	[SerializeField]private GameObject _bullet;
	[SerializeField]private GameObject _nozzle;
	private float _reloadTime = 3f;
	private float _time;

	private void Update() {
		_time += Time.deltaTime;
		if (_time > _reloadTime) {
			_time = 0;
			Shoot ();
		}
	}

	private void Shoot() {
		Instantiate (_bullet, _nozzle.transform.position, transform.rotation);
	}
}
