using UnityEngine;

public class BaseWeaponData : MonoBehaviour {

    [SerializeField]
    protected float cooldownTime = 5; // Delay between shots.

    [SerializeField]
    protected float spread = 0; // Spread of bullets.

    [SerializeField]
    protected GameObject bulletPrefab; // Bullet to copy.

    [SerializeField]
    protected float shotsToFire = 1; // How many bullets are fired when triggered.

    protected bool coolingDown = false; // Has enough time passed. (fireRate)

    // Outside classes are allowed to edit this.
    public bool triggerDown = false; // Is the player holding the trigger.


    // Bullet related variables

    [SerializeField]
    protected float bulletLifetime = 10; // How long the bullets I fire live for.

    [SerializeField]
    protected float bulletSpeed = 5; // How fast the bullets I fire are.

    [SerializeField]
    protected float bulletPenetrationLives = 0; // How much objects my bullets will penetrate.
}
