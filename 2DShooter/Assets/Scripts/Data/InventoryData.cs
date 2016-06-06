using UnityEngine;
using System.Collections.Generic;

public class InventoryData : MonoBehaviour {

    // All weapons I'm holding.
    [SerializeField]
    protected List<BaseWeaponData> weapons = new List<BaseWeaponData>();

    protected BaseWeapon heldWeapon;
}
