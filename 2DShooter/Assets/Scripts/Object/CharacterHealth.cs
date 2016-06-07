using UnityEngine;

public class CharacterHealth : CharacterHealthData {
    void Start() {
        Damage = DamageHandler;
        Heal = HealHandler;
    }

    void DamageHandler(int damage) {
        if (alive) {
            if (damage <= 0) {
                Debug.LogError("Value below 0, use Heal() for that.");
                return;
            }
            health -= damage;
            if (health <= 0) {
                Death();
            }
        }
    }

    void HealHandler(int health) {
        if (alive) {
            if (health <= 0) {
                Debug.LogError("Value below 0, use Damage() for that.");
                return;
            }
            health += health;
            if (health > maxHealth) {
                health = maxHealth;
            }
        }
    }

    void Death() {
        alive = false;
        transform.position = new Vector3(transform.position.x, transform.position.y - transform.lossyScale.y / 2, transform.position.z);
        transform.Rotate(new Vector3(0, 0, 90));
    }
}
