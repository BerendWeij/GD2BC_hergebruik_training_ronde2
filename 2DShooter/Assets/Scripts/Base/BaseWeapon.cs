using System.Collections;
using UnityEngine;

public class BaseWeapon : BaseWeaponData {

    void Fire() {
        if (!coolingDown && !reloading) {
            if (clip >= 1) {
                clip--;
                coolingDown = true;
                StartCoroutine(coolingDownTimer());
                for (int i = 0; i < shotsToFire; i++) {

                    GameObject bulletObject = Instantiate(bulletPrefab);
                    Transform btf = bulletObject.transform;
                    Bullet bullet = bulletObject.GetComponent<Bullet>();

                    btf.rotation = transform.rotation;
                    btf.Rotate(new Vector3(0, 0, Random.Range(-spread, spread)));

                    Vector3 bulletPosition = transform.position + transform.right;

                    btf.position = bulletPosition;

                    bullet.Lifetime = bulletLifetime;
                    bullet.FlightSpeed = bulletSpeed;
                    bullet.PenetrationLives = bulletPenetrationLives;
                    bullet.Parent = gameObject;
                }
            } else {
                StartCoroutine(reloadingTimer());
            }
        }
    }

    void Update() {
        if (triggerDown) {
            Fire();
        }
    }

    public void Aim(Vector3 target) {
        Vector3 dir = target - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    IEnumerator coolingDownTimer() {
        yield return new WaitForSeconds(cooldownTime);
        coolingDown = false;
    }

    IEnumerator reloadingTimer() {
        reloading = true;
        clip = clipSize;
        yield return new WaitForSeconds(reloadTime);
        reloading = false;
    }
}
