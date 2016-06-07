using UnityEngine;

public class CharacterHealthData : MonoBehaviour {
    [SerializeField]
    protected int health, maxHealth = 100;

    protected bool alive = true;

    public int Health {
        get { return health; }
    }

    public int MaxHealth {
        get { return maxHealth; }
        set { maxHealth = value; }
    }

    public bool Alive {
        get { return alive; }
    }

    public delegate void DamageDel(int damage);
    public delegate void HealDel(int health);

    public DamageDel Damage;
    public HealDel Heal;
}
