using UnityEngine;
using System.Collections;

public class Inventory : InventoryData {

    void Start() {
        heldWeapon = transform.FindChild("Weapon").GetComponent<BaseWeapon>();
    }

    void ChangeWeapon(BaseWeaponData newWeapon) {
        heldWeapon.PasteData(newWeapon.CopyData());
    }

    void ChangeWeapon(ArrayList dataArray) {
        heldWeapon.PasteData(dataArray);
    }

    public void EquipRandomWeapon() {
        BaseWeaponData newWeapon = Instantiate(weapons[Random.Range(0, weapons.Count)]).GetComponent<BaseWeaponData>();
        newWeapon.SetupData();
        ChangeWeapon(newWeapon.CopyData());
        heldWeapon.Clip = newWeapon.ClipSize;
        Destroy(newWeapon.gameObject);
    }

    public BaseWeapon GetWeapon() {
        return heldWeapon;
    }
}
