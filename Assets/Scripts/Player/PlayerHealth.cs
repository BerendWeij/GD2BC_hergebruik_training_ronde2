using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour, IDamageable, IDestructable {
	[SerializeField]private Image _healthBar;
	private float _maxHealth = 100f;
	private float _health = 100f;

	private void Update() {
		_healthBar.fillAmount = (1f / _maxHealth) * _health;
		if (_health <= 0) {
			Destruct();
		}
	}

	public void TakeDamage(float dmg) {
		_health -= dmg;
	}

	public void Destruct() {
		Destroy (this.gameObject);
	}
}
