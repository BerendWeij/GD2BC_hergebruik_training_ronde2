using UnityEngine;

public class KeyboardInput : MonoBehaviour {

    bool up, down, left, right, fire, altFire = false;

    PlayerMovement pm;
    BaseWeapon bw;
    Inventory inv;

    [SerializeField]
    KeyCode keyUp, keyDown, keyLeft, keyRight, keySpace;

    void Start() {
        pm = GetComponent<PlayerMovement>();
        inv = GetComponent<Inventory>();
        bw = inv.GetWeapon();
    }

    void Update() {
        KeyDown();

        if (altFire) {
            inv.EquipRandomWeapon();
        }
        bw.triggerDown = fire;
        pm.Move(right, left, up);
        bw.Aim(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    void KeyDown() {
        up = down = left = right = fire = false;

        up = GK(keyUp) || GK(keySpace);
        down = GK(keyDown);
        left = GK(keyLeft);
        right = GK(keyRight);
        fire = Input.GetMouseButton(0);
        altFire = Input.GetMouseButton(1);
    }

    bool GK(KeyCode keyCode) {
        return Input.GetKey(keyCode);
    }
}
