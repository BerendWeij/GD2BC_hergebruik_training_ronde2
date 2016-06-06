using UnityEngine;

public class TurretAI : MonoBehaviour {

    BaseWeapon bw;

    [SerializeField]
    Sprite machineGun;

    void Start() {
        bw = GetComponent<BaseWeapon>();
        bw.triggerDown = true;

        bw.WeaponName = "Machine Gun";
        bw.ClipSize = 255;
        bw.Clip = bw.ClipSize;
        bw.WeaponSprite = machineGun;
        bw.Spread = 1;
        bw.BulletSpeed = 15;
        bw.ReloadTime = 1;
    }

}
