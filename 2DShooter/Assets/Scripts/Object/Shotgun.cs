using UnityEngine;

public class Shotgun : BaseWeaponData {
    public override void SetupData() {
        weaponName = "Shotgun";
        cooldownTime = 3f;
        spread = 10;
        shotsToFire = 7;
        clipSize = 6;
        clip = 6;
        reloadTime = 5;
        bulletLifetime = 10;
        bulletSpeed = 10;
        bulletPenetrationLives = 5;
        bulletDamage = 5;
    }
}
