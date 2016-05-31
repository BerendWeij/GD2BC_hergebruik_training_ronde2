using System.Collections;
using UnityEngine;

public class BaseWeapon : BaseWeaponData {

    void Fire() {
        if (!coolingDown) {
            coolingDown = true;
            StartCoroutine(coolingDownTimer());
            for (int i = 0; i < shotsToFire; i++) {
                GameObject bulletObject = Instantiate(bulletPrefab);
                Transform btf = bulletObject.transform; // Bullet Transform.
                Bullet bullet = bulletObject.GetComponent<Bullet>();

                btf.Rotate(new Vector3(0,0,Random.Range(-spread, spread)));

                Vector3 bulletPosition = transform.position;
                bulletPosition.x += transform.lossyScale.x; ;

                btf.position = bulletPosition;

                bullet.Lifetime = bulletLifetime;
                bullet.FlightSpeed = bulletSpeed;
                bullet.PenetrationLives = bulletPenetrationLives;

            }
        }
    }

    void Update() {
        if (triggerDown) {
            Fire();
        }
    }

    IEnumerator coolingDownTimer() {
        yield return new WaitForSeconds(cooldownTime);
        coolingDown = false;
    }
}
