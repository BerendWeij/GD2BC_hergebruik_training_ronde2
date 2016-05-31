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
}
