using UnityEngine;
using System.Collections;

public class PillowWeapon : WeaponBase, IWeapon {
	private float _curTime;

	private void Start ()
	{
		_curTime = _reloadTime;
	}

	private void Update ()
	{
		_curTime += Time.deltaTime;
	}

	public void Shoot ()
	{
		if (_curTime >= _reloadTime) {
			Instantiate (_bullet, _nozzle.position, transform.rotation);
			_curTime = 0;
		}
	}
}
