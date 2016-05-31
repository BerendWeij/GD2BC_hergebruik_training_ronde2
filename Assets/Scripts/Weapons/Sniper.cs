using UnityEngine;
using System.Collections;

public class Sniper : MonoBehaviour, IWeapon
{
    private Weapon _weapon;
	// Use this for initialization
	void Start()
	{
        _weapon.damage = 10f;
        _weapon.range = 100f;
        _weapon.reloadTime = 3f;
        _weapon.ammo = 5;
        _weapon.weaponName = "Sniper";
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