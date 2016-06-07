﻿using UnityEngine;

public class Uzi : BaseWeaponData {
    public override void SetupData() {
        weaponName = "Uzi";
        cooldownTime = 0.05f;
        spread = 5;
        shotsToFire = 1;
        clipSize = 30;
        clip = 30;
        reloadTime = 5;
        bulletLifetime = 10;
        bulletSpeed = 10;
        bulletPenetrationLives = 0;
        bulletDamage = 5;
    }
}