using UnityEngine;
using System.Collections.Generic;

public class InventoryData : MonoBehaviour {

    // All weapons I'm holding.
    [SerializeField]
    protected List<GameObject> weapons = new List<GameObject>();

    protected BaseWeapon heldWeapon;
}
