using UnityEngine;
using System.Collections;

public class MiniGun : MonoBehaviour, IWeapon
{
    private Weapon _weapon;
	// Use this for initialization
	void Start()
	{
        _weapon.damage = 10f;
        _weapon.range = 10f;
        _weapon.reloadTime = 1f;
        _weapon.ammo = 200;
        _weapon.weaponName = "Mini Gun";
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