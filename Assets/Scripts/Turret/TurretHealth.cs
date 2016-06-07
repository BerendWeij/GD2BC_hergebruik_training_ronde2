using UnityEngine;
using System.Collections;

public class TurretHealth : MonoBehaviour, IDamageable, IDestructable {
	private float _health = 100f;

	private void Update () {
		if (_health <= 0) {
			Destruct ();
		}
	}

	public void TakeDamage(float dmg) {
		_health -= dmg;	
	}

	public void Destruct() {
		Destroy (this.gameObject);
	}
}
