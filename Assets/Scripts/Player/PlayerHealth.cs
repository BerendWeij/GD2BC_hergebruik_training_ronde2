using UnityEngine;
using System.Collections;

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

    void Start()
    {
        curHealth = maxHealth;
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

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

}
