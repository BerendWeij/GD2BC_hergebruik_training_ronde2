using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    [SerializeField]
    Slider healthBar;

    CharacterHealth healthContainer;

    void Start() {
        healthContainer = GetComponent<CharacterHealth>();
    }

    void FixedUpdate() {
        healthBar.maxValue = healthContainer.MaxHealth;
        healthBar.value = healthContainer.Health;
    }
}
