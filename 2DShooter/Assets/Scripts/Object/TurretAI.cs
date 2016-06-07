using UnityEngine;

public class TurretAI : MonoBehaviour {

    BaseWeapon bw;

    [SerializeField]
    Sprite newGunSprite;

    void Start() {
        bw = GetComponent<BaseWeapon>();
        bw.triggerDown = true;

        if (newGunSprite != null) {
            bw.WeaponName = "Machine Gun";
            bw.ClipSize = 255;
            bw.Clip = bw.ClipSize;
            bw.WeaponSprite = newGunSprite;
            bw.Spread = 1;
            bw.BulletSpeed = 15;
            bw.ReloadTime = 1;
            bw.BulletPenetrationLives = 5;
        }

        bw.Turret = true;
    }

}
