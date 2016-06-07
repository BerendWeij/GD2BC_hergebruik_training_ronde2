using UnityEngine;
using System.Collections;

public class BaseWeaponData : MonoBehaviour {
    [SerializeField]
    protected string weaponName = "BaseWeapon";

    [SerializeField]
    protected Sprite weaponSprite;

    [SerializeField]
    protected float cooldownTime = 5; // Delay between shots.

    [SerializeField]
    protected float spread = 0; // Spread of bullets.

    [SerializeField]
    protected GameObject bulletPrefab; // Bullet to copy.

    [SerializeField]
    protected int shotsToFire = 1; // How many bullets are fired when triggered.

    [SerializeField]
    protected int clipSize, clip = 30;

    [SerializeField]
    protected float reloadTime = 5;
    protected bool reloading = false;

    protected bool coolingDown = false; // Has enough time passed. (fireRate)

    // Outside classes are allowed to edit this.
    public bool triggerDown = false; // Is the player holding the trigger.

    // Bullet related variables

    [SerializeField]
    protected float bulletLifetime = 10; // How long the bullets I fire live for.

    [SerializeField]
    protected float bulletSpeed = 5; // How fast the bullets I fire are.

    [SerializeField]
    protected int bulletPenetrationLives = 0; // How much objects my bullets will penetrate.

    [SerializeField]
    protected int bulletDamage = 1;

    protected SpriteRenderer spriteRenderer;

    protected bool turret = false;

    public virtual void SetupData() {
        // To be replaced by weapons containing data.
        Debug.LogError("Don't ask ReturnData() from " + this.GetType() + ".");
    }

    public ArrayList CopyData() {
        ArrayList items = new ArrayList(12);

        items.Add(weaponName);
        items.Add(weaponSprite);
        items.Add(cooldownTime);
        items.Add(spread);
        items.Add(bulletPrefab);
        items.Add(shotsToFire);
        items.Add(clipSize);
        items.Add(reloadTime);
        items.Add(bulletLifetime);
        items.Add(bulletSpeed);
        items.Add(bulletPenetrationLives);
        items.Add(bulletDamage);

        return items;
    }

    public void PasteData(ArrayList items) {
        weaponName = (string)items[0];
        weaponSprite = (Sprite)items[1];
        cooldownTime = (float)items[2];
        spread = (float)items[3];
        bulletPrefab = (GameObject)items[4];
        shotsToFire = (int)items[5];
        clipSize = (int)items[6];
        reloadTime = (float)items[7];
        bulletLifetime = (float)items[8];
        bulletSpeed = (float)items[9];
        bulletPenetrationLives = (int)items[10];
        bulletDamage = (int)items[11];

        UpdateSprite();
    }

    void UpdateSprite() {
        if(spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = weaponSprite;
    }
    public string WeaponName {
        get { return weaponName; }
        set { weaponName = value; }
    }

    public Sprite WeaponSprite {
        get { return weaponSprite; }
        set { 
            weaponSprite = value;
            UpdateSprite();
        }
    }

    public float CooldownTime {
        get { return cooldownTime; }
        set { cooldownTime = value; }
    }

    public float Spread {
        get { return spread; }
        set { spread = value; }
    }

    public GameObject BulletPrefab {
        get { return bulletPrefab; }
        set { bulletPrefab = value; }
    }

    public int ShotsToFire {
        get { return shotsToFire; }
        set { shotsToFire = value; }
    }

    public int ClipSize {
        get { return clipSize; }
        set { clipSize = value; }
    }

    public int Clip {
        get { return clip; }
        set { clip = value; }
    }

    public float ReloadTime {
        get { return reloadTime; }
        set { reloadTime = value; }
    }

    public float BulletLifetime {
        get { return bulletLifetime; }
        set { bulletLifetime = value; }
    }

    public float BulletSpeed {
        get { return bulletSpeed; }
        set { bulletSpeed = value; }
    }

    public int BulletPenetrationLives {
        get { return bulletPenetrationLives; }
        set { bulletPenetrationLives = value; }
    }

    public bool Turret {
        get { return turret; }
        set { turret = value; }
    }
}
