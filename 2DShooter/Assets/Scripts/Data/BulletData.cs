using UnityEngine;
using System.Collections.Generic;

public class BulletData : MonoBehaviour {

    [SerializeField]
    protected float flightSpeed; // How fast I go.

    [SerializeField]
    protected float lifetime; // The amount of seconds before I die.

    [SerializeField]
    protected float penetrationLives; // The amount of times I can pass an object before dying.

    [SerializeField]
    protected float flightSpeedDivider = 30; // Usually not going to edit this so I'll pass a default.

    protected List<GameObject> penetratedObjects = new List<GameObject>(); // The list of objects I have penetrated and will ignore.

    protected GameObject gun, shooter;

    protected int damage;

    public float FlightSpeed {
        set { flightSpeed = value; }
        get { return flightSpeed; }
    }

    public float Lifetime {
        set { lifetime = value; }
        get { return lifetime; }
    }

    public float PenetrationLives {
        set { penetrationLives = value; }
        get { return penetrationLives; }
    }

    public GameObject Gun {
        get { return gun; }
        set { gun = value; }
    }

    public GameObject Shooter {
        get { return shooter; }
        set { shooter = value; }
    }

    public int Damage {
        get { return damage; }
        set { damage = value; }
    }
}
