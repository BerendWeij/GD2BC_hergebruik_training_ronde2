using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour
{
    [SerializeField]private float _health;
                    private float _healthOffset;
    [SerializeField]private Image _healthBar;
	
    void Start()
    {
        _healthOffset = _health;
    }

    private void TakeDamage(int damage)
    {
        _health -= damage;
        CaluclateHealth();
        if(_health <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void CaluclateHealth()
    {
        _healthBar.fillAmount = _health / _healthOffset;
    }
}