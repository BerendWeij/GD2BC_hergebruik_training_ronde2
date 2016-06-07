using UnityEngine;

public class Bullet : BulletData {

    void Update() {
        UpdateMovement();
        UpdateLifetime();
    }

    void OnTriggerEnter2D(Collider2D other) {
        // Check if it's not in the list of objects I've already passed through.

        if (other.gameObject == gun || other.gameObject == shooter) {
            return;
        }

        if (penetratedObjects.IndexOf(other.gameObject) == -1 && other.gameObject.GetComponent<Bullet>() == null) {
            CharacterHealth health = other.GetComponent<CharacterHealth>();

            if (health != null) {
                health.Damage(damage);
            }

            if (penetrationLives > 0) {
                penetrationLives--;
                penetratedObjects.Add(other.gameObject);
            } else {
                Destroy(gameObject);
                return;
            }
        }
    }

    void UpdateMovement() {
        transform.position += transform.right * (flightSpeed / flightSpeedDivider);
    }

    void UpdateLifetime() {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0) {
            Destroy(gameObject);
        }
    }
}
