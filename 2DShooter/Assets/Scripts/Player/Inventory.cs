using UnityEngine;

public class Inventory : InventoryData {

    void Start() {
        heldWeapon = transform.FindChild("Weapon").GetComponent<BaseWeapon>();
    }

    void ChangeWeapon(BaseWeapon oldWeapon, BaseWeaponData newWeapon) {
        oldWeapon.PasteData(newWeapon.CopyData());
    }

    public BaseWeapon GetWeapon() {
        return heldWeapon;
    }
}
