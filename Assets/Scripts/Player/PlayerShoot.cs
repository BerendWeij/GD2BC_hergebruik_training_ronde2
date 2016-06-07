using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	private IWeapon _curWeapon;
	private IWeapon[] _weapons;

	private void Start() {
		_weapons = GetComponents<IWeapon> ();
	}

	public void Shoot() {
		_curWeapon = _weapons.GetRandomInArray();
		_curWeapon.Shoot ();
	}
}
