using UnityEngine;
using System.Collections;

public class HandGun : MonoBehaviour, IWeapon
{
    private Weapon _weapon;
	// Use this for initialization
	void Start()
	{
        _weapon.damage = 2f;
        _weapon.range = 10f;
        _weapon.reloadTime = .5f;
        _weapon.ammo = 20;
        _weapon.weaponName = "Hand Gun";
	}
	
	// Update() is called once per frame
	void Update()
	{
		
	}

    public void Shoot()
    {
        Debug.Log("Shooting: " + _weapon.weaponName);
    }

    public void Reload()
    {
        Debug.Log("Reloading: " + _weapon.weaponName);
    }
}