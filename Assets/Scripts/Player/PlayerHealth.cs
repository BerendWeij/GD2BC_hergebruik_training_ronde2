using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    float maxHealth = 100f;
    [SerializeField]
    float curHealth = 0f;
    [SerializeField]
    float damage;
    [SerializeField]
    GameObject healthBar;
    [SerializeField]private Image _timerBar;
    [SerializeField]private float _maxTimeInSeconds;
    private float _timer;

    void Start()
    {
        curHealth = maxHealth;
        _timer = _maxTimeInSeconds;
    }

    void Update()
    {
        Timer();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == Tags.PROJECTILE)
        {
            DecreaseHealth();
        }
    }

    void DecreaseHealth()
    {
        curHealth -= damage;
        float calcHealth = curHealth / maxHealth;
        SetHealthBar(calcHealth);
    }

    void Timer()
    {
        if(_timer > 0)
        {
            _timer -= Time.deltaTime;
            _timerBar.fillAmount = (_timer / _maxTimeInSeconds);
        }
    }

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

}
